using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class MyAccout : Form
    {
        // Biến thành viên (global variable trong class) để lưu trữ user_id
        private string _userId;

        public MyAccout()
        {
            InitializeComponent();

            // Lấy user_id từ biến tĩnh/toàn cục fLogin và lưu vào biến thành viên
            _userId = fLogin.UserId.ToString();

            // Gọi hàm hiển thị thông tin khi Form được khởi tạo
            HienThiTK();
            HienThiDonHang();
        }

        private void HienThiTK()
        {
            if (string.IsNullOrEmpty(_userId))
            {
                MessageBox.Show("Lỗi: Không thể xác định ID người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Truy vấn thông tin tài khoản
            string query = @"
                SELECT username, password, full_name, phone_number, email, address 
                FROM Users 
                WHERE user_id = @user_id";

            var parameters = new[] { new SqlParameter("@user_id", _userId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                // Gán dữ liệu vào TextBox
                txtUserName.Text = row["username"].ToString();
    
                txtFull_Name.Text = row["full_name"].ToString();
                txtPhone_Number.Text = row["phone_number"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtAddress.Text = row["address"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của UserId 
            if (string.IsNullOrEmpty(_userId))
            {
                MessageBox.Show("Lỗi: Không thể xác định tài khoản để cập nhật.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1: Kiểm tra các trường BẮT BUỘC (Trừ Password, có thể để trống nếu không đổi)
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFull_Name.Text) ||
                string.IsNullOrWhiteSpace(txtPhone_Number.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text)
                )
            {
                MessageBox.Show("Vui lòng không để trống các thông tin bắt buộc!", "Lỗi",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2. LẤY DỮ LIỆU HIỆN TẠI (Dùng _userId)
                string selectQuery = @"
                    SELECT username, password, email, full_name, phone_number, address
                    FROM Users  
                    WHERE user_id = @user_id";

                var selectParams = new[] { new SqlParameter("@user_id", _userId) };
                DataTable currentData = DatabaseHelper.ExecuteQuery(selectQuery, selectParams);

                if (currentData == null || currentData.Rows.Count == 0)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy tài khoản để cập nhật.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = currentData.Rows[0];

                // Lấy giá trị mới và cũ
                string newUsername = txtUserName.Text.Trim();
                
                string oldUsername = row["username"].ToString();

                // 3. XÂY DỰNG UPDATE
                var updateFields = new List<string>();
                var updateParams = new List<SqlParameter>();

                // Tham số cho điều kiện WHERE
                updateParams.Add(new SqlParameter("@user_id", _userId));


                // KIỂM TRA USERNAME: Nếu username thay đổi, phải kiểm tra trùng lặp
                if (newUsername != oldUsername)
                {
                    // Kiểm tra xem username mới đã bị người khác sử dụng chưa
                    string checkUsernameQuery = "SELECT COUNT(*) FROM Users WHERE username = @newUsername AND user_id != @user_id";
                    var checkUsernameParams = new[] {
                         new SqlParameter("@newUsername", newUsername),
                         new SqlParameter("@user_id", _userId)
                     };
                    int usernameCount = (int)DatabaseHelper.ExecuteScalar(checkUsernameQuery, checkUsernameParams.ToArray());

                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Tên tài khoản này đã tồn tại. Vui lòng chọn tên khác.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    updateFields.Add("username = @username");
                    updateParams.Add(new SqlParameter("@username", newUsername));
                }

                // KIỂM TRA VÀ THÊM CÁC TRƯỜNG KHÁC (Chỉ thêm nếu có thay đổi)
                if (txtEmail.Text.Trim() != row["email"].ToString())
                {
                    updateFields.Add("email = @email");
                    updateParams.Add(new SqlParameter("@email", txtEmail.Text.Trim()));
                }

                if (txtFull_Name.Text.Trim() != row["full_name"].ToString())
                {
                    updateFields.Add("full_name = @full_name");
                    updateParams.Add(new SqlParameter("@full_name", txtFull_Name.Text.Trim()));
                }

                if (txtPhone_Number.Text.Trim() != row["phone_number"].ToString())
                {
                    updateFields.Add("phone_number = @phone_number");
                    updateParams.Add(new SqlParameter("@phone_number", txtPhone_Number.Text.Trim()));
                }

                if (txtAddress.Text.Trim() != row["address"].ToString())
                {
                    updateFields.Add("address = @address");
                    updateParams.Add(new SqlParameter("@address", txtAddress.Text.Trim()));
                }



                // 4. THỰC HIỆN CẬP NHẬT
                if (updateFields.Count == 0)
                {
                    MessageBox.Show("Không có thông tin nào được thay đổi.");
                    return;
                }

                // Câu lệnh UPDATE cuối cùng dựa trên user_id
                string updateQuery = $"UPDATE Users SET {string.Join(", ", updateFields)} WHERE user_id = @user_id";
                int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams.ToArray());

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                    // Làm mới form sau khi cập nhật thành công (nếu cần)
                    HienThiTK();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //========================================= hiển thị thông tin đơn hàng của user hiện tại =========================================
        private void HienThiDonHang()
        {
            if (string.IsNullOrEmpty(_userId))
            {
                MessageBox.Show("Lỗi: Không thể xác định ID người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SỬA LỖI 1: Đặt bí danh (AS O, AS U) và sử dụng tham số (@user_id)
            string query = $@"
SELECT 
    O.order_id, -- Dùng O.order_id để tránh mơ hồ nếu có cột cùng tên
    O.order_date,
    U.full_name,
    U.phone_number,
    O.shipping_address, -- Giả sử địa chỉ giao hàng nằm trong Orders
    O.total_amount,
    O.order_status
FROM Orders AS O -- Bí danh O
INNER JOIN Users AS U ON O.user_id = U.user_id -- Bí danh U
WHERE O.user_id = @user_id"; // CHỈNH SỬA: Lọc theo tham số @user_id và chỉ định O.user_id

            var parameters = new[] { new SqlParameter("@user_id", _userId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvDonHang.DataSource = dt;

                // SỬA LỖI 2: Đảm bảo tên cột khớp với câu lệnh SELECT
                dgvDonHang.Columns["order_id"].HeaderText = "Mã Đơn Hàng";
                dgvDonHang.Columns["order_date"].HeaderText = "Ngày Đặt";
                dgvDonHang.Columns["full_name"].HeaderText = "Tên Khách Hàng";
                dgvDonHang.Columns["phone_number"].HeaderText = "SĐT Khách Hàng";
                dgvDonHang.Columns["shipping_address"].HeaderText = "Địa Chỉ Giao Hàng";
                dgvDonHang.Columns["total_amount"].HeaderText = "Tổng Tiền";
                dgvDonHang.Columns["order_status"].HeaderText = "Trạng Thái"; // Tên cột đúng là order_status

                dgvDonHang.Columns["total_amount"].DefaultCellStyle.Format = "N0";
            }
            
        }
    }
}