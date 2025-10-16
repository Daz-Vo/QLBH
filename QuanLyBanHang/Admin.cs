using Microsoft.Reporting.WinForms;
using QuanLyBanHang.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyBanHang.DatabaseHelper;
using static QuanLyBanHang.Services.BillService;
using QuanLyBanHang.DAL;



namespace QuanLyBanHang
{
    public partial class fAdmin : Form

    {

        public fAdmin()
        {
            InitializeComponent();
            LoadAcountList();
            LoadProductList();
            LoadOrderList(fullQuery);


            dgvTaiKhoan.SelectionChanged += DgvTaiKhoan_SelectionChanged;
            dgvDSSP.SelectionChanged += dgvDSSP_SelectionChanged;
            dgvDSDH.SelectionChanged += dgvDSDH_SelectionChanged;

        }

        //========================================================================== danh sách tài khoản ===========================================================================

        void LoadAcountList()
        {
            try
            {
                string query = "SELECT full_name , username  , password , phone_number  FROM Users";
                //DataProvider Provider = new DataProvider();
                dgvTaiKhoan.DataSource = DatabaseHelper.ExecuteQuery(query);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn danh sách tài khoản " + ex.Message);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string phone_number = txtTim_SDT.Text.Trim();
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE phone_number = @phone_number";
            var checkParams = new[] { new SqlParameter("@phone_number", txtTim_SDT.Text.Trim()) };

            int count = (int)DatabaseHelper.ExecuteScalar(checkQuery, checkParams);

            if (count == 0)
            {
                // Username chưa tồn tại
                MessageBox.Show("Tài khoản chưa tồn tại");
                return;
            }
            else
            {
                // hiển thị thống tin tài khoản
                string query = "SELECT username, password , full_name , phone_number , email , address FROM Users WHERE phone_number = @phone_number"; // tìm ... có sdt = biến
                var parameters = new[] { new SqlParameter("@phone_number", txtTim_SDT.Text.Trim()) };  //gán biến = giá trị trong textbox

                string[] result = DatabaseHelper.ExecuteQueryFirstRow(query, parameters); // thực thi câu truy vấn... có biến...

                if (result != null)
                {
                    // gián giá trị lần lượt theo thứ tự như cây query trên
                    txtUserName.Text = result[0];
                    txtPassWord.Text = result[1];
                    txtFull_Name.Text = result[2];
                    txtPhone_Number.Text = result[3];
                    txtEmail.Text = result[4];
                    txtAddress.Text = result[5];
                }
            }

        }

        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            //1: Kiểm tra tài khoản
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassWord.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFull_Name.Text) ||
                string.IsNullOrWhiteSpace(txtPhone_Number.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text)
                )
            {
                MessageBox.Show("Vui lòng không để trống thông tin!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //2: Kiem tra tài khoản đã tạo hay chưa          
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
            var checkParams = new[] { new SqlParameter("@username", txtUserName.Text.Trim()) };

            try
            {
                int count = (int)DatabaseHelper.ExecuteScalar(checkQuery, checkParams);

                if (count > 0)
                {
                    // 1. Lấy dữ liệu hiện tại từ CSDL
                    string selectQuery = @"
        SELECT password, email, full_name, phone_number, address
        FROM Users 
        WHERE username = @username";

                    var selectParams = new[] { new SqlParameter("@username", txtUserName.Text.Trim()) };
                    DataTable currentData = DatabaseHelper.ExecuteQuery(selectQuery, selectParams);

                    // ✅ Không cần kiểm tra Rows.Count == 0 vì đã có count > 0 ở trên

                    DataRow row = currentData.Rows[0];

                    // Lấy giá trị mới
                    string newPassword = txtPassWord.Text.Trim();
                    string newEmail = txtEmail.Text.Trim();
                    string newFullName = txtFull_Name.Text.Trim();
                    string newPhone = txtPhone_Number.Text.Trim();
                    string newAddress = txtAddress.Text.Trim();

                    // Xây dựng UPDATE
                    var updateFields = new List<string>();
                    var updateParams = new List<SqlParameter>();
                    updateParams.Add(new SqlParameter("@username", txtUserName.Text.Trim())); // Dùng cho WHERE

                    if (newEmail != row["email"].ToString())
                    {
                        updateFields.Add("email = @email");
                        updateParams.Add(new SqlParameter("@email", newEmail));
                    }

                    if (newFullName != row["full_name"].ToString())
                    {
                        updateFields.Add("full_name = @full_name");
                        updateParams.Add(new SqlParameter("@full_name", newFullName));
                    }

                    if (newPhone != row["phone_number"].ToString())
                    {
                        updateFields.Add("phone_number = @phone_number");
                        updateParams.Add(new SqlParameter("@phone_number", newPhone));
                    }

                    if (newAddress != row["address"].ToString())
                    {
                        updateFields.Add("address = @address");
                        updateParams.Add(new SqlParameter("@address", newAddress));
                    }

                    // ⚠️ Mật khẩu: chỉ cập nhật nếu có nhập và khác cũ
                    if (!string.IsNullOrEmpty(newPassword) && newPassword != row["password"].ToString())
                    {
                        updateFields.Add("password = @password");
                        updateParams.Add(new SqlParameter("@password", newPassword));
                    }

                    if (updateFields.Count == 0)
                    {
                        MessageBox.Show("Không có thông tin nào được thay đổi.");
                        return;
                    }

                    // Cập nhật theo username
                    string updateQuery = $"UPDATE Users SET {string.Join(", ", updateFields)} WHERE username = @username";
                    int rowsAffected1 = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams.ToArray());

                    if (rowsAffected1 > 0)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công!");
                        LoadAcountList();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.");
                    }

                    return;
                }

                //3: Nếu chưa tồn tại → chèn mới
                string insertQuery = @"
            INSERT INTO Users (username, password, email, full_name, phone_number, address) 
            VALUES (@username, @password, @email, @full_name, @phone_number, @address)";

                var insertParams = new[]
        {
            new SqlParameter("@username", txtUserName.Text.Trim()),
            new SqlParameter("@password", txtPassWord.Text.Trim()), // ⚠️ Hash nếu cần!
            new SqlParameter("@email", txtEmail.Text.Trim()),
            new SqlParameter("@full_name", txtFull_Name.Text.Trim()),
            new SqlParameter("@phone_number", txtPhone_Number.Text.Trim()),
            new SqlParameter("@address", txtAddress.Text.Trim())
        };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    //load lại dtgv
                    LoadAcountList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //string checkQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
            var checkParams = new[] { new SqlParameter("@username", txtUserName.Text.Trim()) };
            string deleteQuery = "DELETE FROM Users WHERE username = @username"; // xóa tài khoản
            var deleteParams = new[] { new SqlParameter("@username", txtUserName.Text.Trim()) };
            DatabaseHelper.ExecuteQueryFirstRow(deleteQuery, deleteParams);
            LoadAcountList();
            MessageBox.Show("Xóa tài khoản thành công");

        }


        //hiển thị thông tin ra textbox khi ấn vào 1 dòng trong dgv
        private void DgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            HienThiThongTinTaiKhoan();
        }

        private void HienThiThongTinTaiKhoan()
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                // Lấy username từ cột "thứ 1 trong colum dgv" (giả sử là cột thứ 1)
                string username = dgvTaiKhoan.SelectedRows[0].Cells[1].Value?.ToString();

                if (!string.IsNullOrEmpty(username))
                {
                    try
                    {
                        // Truy vấn thông tin tài khoản
                        string query = @"
                    SELECT username, password, full_name, phone_number, email, address 
                    FROM Users 
                    WHERE username = @username";

                        var parameters = new[] { new SqlParameter("@username", username) };
                        DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];

                            // Gán vào TextBox
                            txtUserName.Text = row["username"].ToString();
                            txtPassWord.Text = row["password"].ToString(); // ⚠️ Nên hash!
                            txtFull_Name.Text = row["full_name"].ToString();
                            txtPhone_Number.Text = row["phone_number"].ToString();
                            txtEmail.Text = row["email"].ToString();
                            txtAddress.Text = row["address"].ToString();
                        }
                        else
                        {
                            // Xóa trắng nếu không tìm thấy
                            ClearTextBoxesTK();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message, "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearTextBoxesTK();
                    }
                }
                else
                {
                    ClearTextBoxesTK();
                }
            }
        }

        // Hàm xóa trắng các TextBox
        private void ClearTextBoxesTK()
        {
            txtUserName.Text = "";
            txtPassWord.Text = "";
            txtFull_Name.Text = "";
            txtPhone_Number.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }


        //========================================================================== danh sách sản phẩm ===========================================================================
        void LoadProductList()
        {
            try
            {
                string query = "SELECT barcode , category_id , product_name , description , price , stock_quantity , image_url FROM Products";
                //DataProvider Provider = new DataProvider();
                dgvDSSP.DataSource = DatabaseHelper.ExecuteQuery(query);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn sanh sách sản phẩm " + ex.Message);
            }
        }


        //hiển thị thông tin ra textbox khi ấn vào 1 dòng trong dgv
        private async void dgvDSSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSSP.SelectedRows.Count > 0)
            {
                // Lấy barcode từ cột đầu tiên (hoặc theo tên cột nếu muốn rõ ràng hơn)
                string barcode = dgvDSSP.SelectedRows[0].Cells[0].Value?.ToString();
                await HienThiThongTinSanPham(barcode);
            }
            else
            {
                ClearTextBoxesSP();
                pbImage_url.Image = null;
            }
        }

        private async Task HienThiThongTinSanPham(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                ClearTextBoxesSP();
                pbImage_url.Image = null;
                return;
            }

            try
            {
                string query = @"SELECT TOP (1) 
            [product_id], [product_name], [description], [price], 
            [stock_quantity], [category_id], [image_url], [barcode]
        FROM [QLBH].[dbo].[Products] 
        WHERE barcode = @barcode";

                var parameters = new[] { new SqlParameter("@barcode", barcode) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtTenSP.Text = row["product_name"].ToString();
                    txtGiaSP.Text = row["price"].ToString();
                    txtSoLuongSP.Text = row["stock_quantity"].ToString();
                    txtMoTaSP.Text = row["description"].ToString();
                    txtLinkAnhSP.Text = row["image_url"].ToString();
                    txtMauSP.Text = row["category_id"].ToString();
                    txtMaVachSP.Text = row["barcode"].ToString();

                    // Tải ảnh
                    string imageUrl = row["image_url"].ToString();
                    await LoadImageFromUrl(imageUrl);
                }
                else
                {
                    ClearTextBoxesSP();
                    pbImage_url.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxesSP();
                pbImage_url.Image = null;
            }
        }

        // Hàm riêng để tải ảnh – dễ tái sử dụng và kiểm thử
        private async Task LoadImageFromUrl(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl))
            {
                pbImage_url.Image = null;
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {

                    byte[] imageData = await client.GetByteArrayAsync(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pbImage_url.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                pbImage_url.Image = null;
                MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //hàm xóa dữ liệu trong textbox
        private void ClearTextBoxesSP()
        {
            txtTenSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuongSP.Text = "";
            txtMoTaSP.Text = "";
            txtLinkAnhSP.Text = "";
            txtMauSP.Text = "";
            txtMaVachSP.Text = "";
            pbImage_url.Image = null;
        }

  

        private async void btnTimSP_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM Products WHERE barcode = @barcode";
            var checkParams = new[] { new SqlParameter("@barcode", txtTimSP.Text.Trim()) };

            int count = (int)DatabaseHelper.ExecuteScalar(checkQuery, checkParams);

            if (count == 0)
            {
                // Username chưa tồn tại
                MessageBox.Show("Chưa có sản phẩm nào");
                return;
            }
            else
            {
                string barcode = txtTimSP.Text.Trim();
                await HienThiThongTinSanPham(barcode);
            }
        }

        private void btnThemCapNhatSP_Click(object sender, EventArgs e)
        {
            {
                //1: Kiểm tra thông tin sản phẩm điền vào
                if (string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaSP.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuongSP.Text) ||
                    string.IsNullOrWhiteSpace(txtMoTaSP.Text) ||
                    string.IsNullOrWhiteSpace(txtLinkAnhSP.Text) ||
                    string.IsNullOrWhiteSpace(txtMauSP.Text) ||
                    string.IsNullOrWhiteSpace(txtMaVachSP.Text)
                    )
                {
                    MessageBox.Show("Vui lòng không để trống thông tin!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //2: Kiem tra sản Phẩm đã tạo hay chưa
                string checkQuery = "SELECT COUNT(*) FROM Products WHERE barcode = @barcode";
                var checkParams = new[] { new SqlParameter("@barcode", txtMaVachSP.Text.Trim()) };

                try
                {
                    int count = (int)DatabaseHelper.ExecuteScalar(checkQuery, checkParams);

                    if (count > 0)
                    {
                        // 1. Lấy dữ liệu hiện tại từ CSDL
                        string selectQuery = @"SELECT [product_id]
                        ,[product_name]
                        ,[description]
                        ,[price]
                        ,[stock_quantity]
                        ,[category_id]
                        ,[image_url]
                        ,[barcode]
                        FROM [QLBH].[dbo].[Products] 
                        WHERE barcode = @barcode";

                        var selectParams = new[] { new SqlParameter("@barcode", txtMaVachSP.Text.Trim()) };
                        DataTable currentData = DatabaseHelper.ExecuteQuery(selectQuery, selectParams);


                        DataRow row = currentData.Rows[0];

                        // Lấy giá trị mới
                        string newproduct_name = txtTenSP.Text.Trim();
                        string newprice = txtGiaSP.Text.Trim();
                        string newtock_quantity = txtSoLuongSP.Text.Trim();
                        string newdescription = txtMoTaSP.Text.Trim();
                        string newimage_url = txtLinkAnhSP.Text.Trim();
                        string newcategory_id = txtMauSP.Text.Trim();

                        // Xây dựng UPDATE
                        var updateFields = new List<string>();
                        var updateParams = new List<SqlParameter>();
                        updateParams.Add(new SqlParameter("@barcode", txtMaVachSP.Text.Trim())); // Dùng cho WHERE

                        if (newproduct_name != row["product_name"].ToString())
                        {
                            updateFields.Add("product_name = @product_name");
                            updateParams.Add(new SqlParameter("@product_name", newproduct_name));
                        }

                        if (newprice != row["price"].ToString())
                        {
                            updateFields.Add("price = @price");
                            updateParams.Add(new SqlParameter("@price", newprice));
                        }

                        if (newtock_quantity != row["stock_quantity"].ToString())
                        {
                            updateFields.Add("stock_quantity = @stock_quantity");
                            updateParams.Add(new SqlParameter("@stock_quantity", newtock_quantity));
                        }

                        if (newdescription != row["description"].ToString())
                        {
                            updateFields.Add("description = @description");
                            updateParams.Add(new SqlParameter("@description", newdescription));
                        }

                        if (newimage_url != row["image_url"].ToString())
                        {
                            updateFields.Add("image_url = @image_url");
                            updateParams.Add(new SqlParameter("@image_url", newimage_url));
                        }

                        if (newcategory_id != row["category_id"].ToString())
                        {
                            updateFields.Add("category_id = @category_id");
                            updateParams.Add(new SqlParameter("@category_id", newcategory_id));
                        }

                        if (updateFields.Count == 0)
                        {
                            MessageBox.Show("Không có thông tin nào được thay đổi.");
                            return;
                        }

                        // Cập nhật theo username
                        string updateQuery = $"UPDATE Products SET {string.Join(", ", updateFields)} WHERE barcode = @barcode";
                        int rowsAffected1 = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams.ToArray());

                        if (rowsAffected1 > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công!");
                            LoadProductList();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại.");
                        }

                        return;
                    }

                    //3: Nếu chưa tồn tại → chèn mới
                    string insertQuery = @"
                    INSERT INTO Products (product_name , price , stock_quantity , description , image_url , category_id , barcode) 
                    VALUES (@product_name, @price, @stock_quantity, @description, @image_url, @category_id, @barcode)";


                    var insertParams = new[]
                    {
                    new SqlParameter("@product_name", txtTenSP.Text.Trim()),
                    new SqlParameter("@price", txtGiaSP.Text.Trim()),
                    new SqlParameter("@stock_quantity", txtSoLuongSP.Text.Trim()),
                    new SqlParameter("@description", txtMoTaSP.Text.Trim()),
                    new SqlParameter("@image_url", txtLinkAnhSP.Text.Trim()),
                    new SqlParameter("@category_id", txtMauSP.Text.Trim()),
                    new SqlParameter("@barcode", txtMaVachSP.Text.Trim())
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        //load lại dtgv
                        LoadProductList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            //string checkQuery = "SELECT COUNT(*) FROM Products WHERE barcode = @barcode";
            var checkParams = new[] { new SqlParameter("@barcode", txtMaVachSP.Text.Trim()) };

            string deleteQuery = "DELETE FROM Products WHERE barcode = @barcode"; // xóa sản phẩm
            var deleteParams = new[] { new SqlParameter("@barcode", txtMaVachSP.Text.Trim()) };
            DatabaseHelper.ExecuteQueryFirstRow(deleteQuery, deleteParams);
            LoadProductList();
            MessageBox.Show("Xóa sản phẩm thành công");
        }













        //========================================================================== danh sách đơn hàng===========================================================================

        private void ClearTextBoxesDH()
        {
            txtMaDH.Text = "";
            cbTrangThaiDH.Text = "";
            dgvOrder_Items.DataSource = null;
        }

        string fullQuery = @"
SELECT 
order_id,
order_date,
full_name,
phone_number,
shipping_address,
total_amount,
order_status
FROM Orders 
INNER JOIN Users ON Orders.user_id = Users.user_id";


        void LoadOrderList(string query)
        {
            try
            {
                //DataProvider Provider = new DataProvider();
                // Thực thi câu truy vấn được truyền vào
                dgvDSDH.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn danh sách đơn hàng: " + ex.Message);
            }
        }

        private void btnLoadALL_Click(object sender, EventArgs e)
        {
            LoadOrderList(fullQuery);
        }

        private void btnTimDH_Click(object sender, EventArgs e)
        {
            TimVaHienLendgv();
        }

        void TimVaHienLendgv()
        {

            string checkSDTQuery = "SELECT COUNT(*) FROM Orders INNER JOIN Users ON Orders.user_id = Users.user_id WHERE phone_number = @phone_number";
            string checkMDHQuery = "SELECT COUNT(*) FROM Orders INNER JOIN Users ON Orders.user_id = Users.user_id WHERE order_id = @order_id";
            var checkSDTParams = new[] { new SqlParameter("@phone_number", txtTimDH.Text.Trim()) };
            var checkMDHParams = new[] { new SqlParameter("@order_id", txtTimDH.Text.Trim()) };
            int countSDT = (int)DatabaseHelper.ExecuteScalar(checkSDTQuery, checkSDTParams);
            int countMDH = (int)DatabaseHelper.ExecuteScalar(checkMDHQuery, checkMDHParams);
            //tim danh sach don hang theo sdt
            if (countSDT == 0 && countMDH == 0)
            {
                MessageBox.Show("không tim thấy đơn hàng");
                return;
            }

            if (countMDH != 0)
            {
                //tim danh sach don hang theo ma don hang
                string order_id = txtTimDH.Text.Trim();
                string QueryMDH = $@"
    SELECT 
    order_id,
    order_date,
    full_name,
    phone_number,
    shipping_address,
    total_amount,
    order_status
    FROM Orders 
    INNER JOIN Users ON Orders.user_id = Users.user_id
    WHERE order_id = '{order_id}'"; // NỐI TRỰC TIẾP GIÁ TRỊ VÀO CHUỖI SQL

                LoadOrderList(QueryMDH); // Giữ nguyên hàm LoadOrderList cũ (chỉ nhận query)
            }
            else
            {
                string phone_number = txtTimDH.Text.Trim();
                string QuerySDT = $@"
    SELECT 
    order_id,
    order_date,
    full_name,
    phone_number,
    shipping_address,
    total_amount,
    order_status
    FROM Orders 
    INNER JOIN Users ON Orders.user_id = Users.user_id
    WHERE phone_number = '{phone_number}'";

                LoadOrderList(QuerySDT);

            }



        }

        private async void dgvDSDH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSDH.SelectedRows.Count > 0)
            {
                // Lấy barcode từ cột đầu tiên (0)
                string order_id = dgvDSDH.SelectedRows[0].Cells[0].Value?.ToString();
                await HienThiThongTinDonHang(order_id);
            }
            else
            {
                ClearTextBoxesDH();
            }
        }

        private async Task HienThiThongTinDonHang(string order_id)
        {
            if (string.IsNullOrEmpty(order_id))
            {
                ClearTextBoxesDH();
                return;
            }

            try
            {
                string query = @"SELECT TOP (1) [order_id]
      ,[user_id]
    
      ,[order_status]
  FROM [QLBH].[dbo].[Orders] WHERE order_id = @order_id";

                var parameters = new[] { new SqlParameter("@order_id", order_id) };
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtMaDH.Text = row["order_id"].ToString();
                    cbTrangThaiDH.Text = row["order_status"].ToString();

                    using (var QLDB = new QLDB_DB())
                    {
                        try
                        {
                            int orderId = Convert.ToInt32(order_id); // ← CHUYỂN ĐỔI TRƯỚC

                            using (var QLDB_DB = new QLDB_DB())
                            {
                                try
                                {
                                    var chiTietDonHang = await Task.Run(() =>
                                        QLDB_DB.Order_Items
                                            .Where(oi => oi.order_id == orderId) // ← DÙNG BIẾN ĐÃ CHUYỂN ĐỔI
                                            .Select(oi => new
                                            {
                                                TenSanPham= oi.Product.product_name,
                                                SoLuong = oi.quantity,
                                                GiaDonVi = oi.price_per_item,
                                                ThanhTien = oi.quantity * oi.price_per_item
                                            })
                                            .ToList()
                                    );
                                    dgvOrder_Items.AutoGenerateColumns = false;

                                    dgvOrder_Items.DataSource = chiTietDonHang;

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi tải chi tiết đơn hàng (EF): {ex.Message}", "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    ClearTextBoxesDH();
                    // xóa thông tin trong dgvOdrer_Items
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxesDH();

            }
        }

        private void btnCapNhatDH_Click(object sender, EventArgs e)
        {
            // cập nhật đơn hàng với mã đơn hàng và trạng thái mới
            if (string.IsNullOrWhiteSpace(txtMaDH.Text) ||
                string.IsNullOrWhiteSpace(cbTrangThaiDH.Text)
                )
            {
                MessageBox.Show("Vui lòng không để trống thông tin!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkMDHQuery = "SELECT COUNT(*) FROM Orders INNER JOIN Users ON Orders.user_id = Users.user_id WHERE order_id = @order_id";
            var checkMDHParams = new[] { new SqlParameter("@order_id", txtMaDH.Text.Trim()) };
            int countMDH = (int)DatabaseHelper.ExecuteScalar(checkMDHQuery, checkMDHParams);
            //tim danh sach don hang theo sdt
            if (countMDH == 0)
            {
                string maDonHang = txtMaDH.Text.Trim();

                MessageBox.Show($"Đơn hàng: Mã {maDonHang} không tồn tại!", "Cập nhật trạn thái đơn hàng thất bại",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = "UPDATE Orders SET order_status = @order_status WHERE order_id = @order_id";

            // Khai báo mảng updateParams[] parameters
            var updateParams = new[]
            {
                // Tham số 1: Tên là @new_status, Giá trị là newStatus
                new SqlParameter("@order_status", cbTrangThaiDH.Text.Trim()),
                new SqlParameter("@order_id", txtMaDH.Text.Trim())
            };
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(updateQuery, updateParams);


            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật trạng thái đơn hàng thành công!");
                TimMDHVaHienLendgv();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");

            }
            
        }
        void TimMDHVaHienLendgv()
        {
            string order_id = txtMaDH.Text.Trim();
            string QueryMDH = $@"
    SELECT 
    order_id,
    order_date,
    full_name,
    phone_number,
    shipping_address,
    total_amount,
    order_status
    FROM Orders 
    INNER JOIN Users ON Orders.user_id = Users.user_id
    WHERE order_id = '{order_id}'"; // NỐI TRỰC TIẾP GIÁ TRỊ VÀO CHUỖI SQL

            LoadOrderList(QueryMDH); // Giữ nguyên hàm LoadOrderList cũ (chỉ nhận query)

        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            DatabaseHelper.XoaDonHang(txtMaDH.Text.Trim());
            LoadOrderList(fullQuery);


        }



        //========================================================================== Report ===========================================================================

        private void rpBill_Load(object sender, EventArgs e)
        {
            // Không cần gọi RefreshReport() ở đây — vì chưa có dữ liệu
            // Xoá dòng này để tránh refresh lúc trống
        }

        private void LoadReport(int orderId)
        {
            try
            {
                using (var context = new QLDB_DB())
                {
                    var service = new BillService(context);
                    var bill = service.GetBillByOrderId(orderId);
                    var dataSet = ReportHelper.ConvertBillToDataSet(bill);

                    rpBill.LocalReport.DataSources.Clear();

                    rpBill.LocalReport.DataSources.Add(new ReportDataSource("ThongTinDonHang", dataSet.Tables["BillInfo"]));
                    rpBill.LocalReport.DataSources.Add(new ReportDataSource("CT_DonHang", dataSet.Tables["BillItems"]));

                    rpBill.RefreshReport(); // ✅ Gọi sau khi gán dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtOrderId.Text, out int orderId))
            {
                LoadReport(orderId);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng hợp lệ!");
            }
        }
    }

}

