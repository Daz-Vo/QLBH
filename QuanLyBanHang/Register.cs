using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyBanHang
{
    public partial class fRegister : Form
    {

        // 1. Tạo một trường để lưu trữ tham chiếu fLogin
        private fLogin _loginForm;

        // 2. Thêm tham số vào Constructor

        public fRegister(fLogin loginForm)
        {
            InitializeComponent();
            this._loginForm = loginForm; // Lưu lại tham chiếu
        }

        private void txtRegister_Click(object sender, EventArgs e)
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
                    // Username đã tồn tại
                    MessageBox.Show("Tên đăng nhập này đã tồn tại! Vui lòng chọn tên khác.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.SelectAll();
                    txtUserName.Focus();
                    return;
                }
                //2: Kiem tra tài khoản đã tạo hay chưa          
                string checkQuerysdt = "SELECT COUNT(*) FROM Users WHERE phone_number = @phone_number";
                var checkParamssdt = new[] { new SqlParameter("@phone_number", txtPhone_Number.Text.Trim()) };

                int countsdt = (int)DatabaseHelper.ExecuteScalar(checkQuerysdt, checkParamssdt);

                if (countsdt > 0)
                {
                    //sdt da ton tai
                    MessageBox.Show("Số điện thoại này đã được đăng ký, vui lòng dùng số khác", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone_Number.SelectAll();
                    txtPhone_Number.Focus();
                    return;
                }

                //3: Nếu chưa tồn tại → chèn mới
                string insertQuery = @"
            INSERT INTO Users (username, password, email, full_name, phone_number, address, authority) 
            VALUES (@username, @password, @email, @full_name, @phone_number, @address, 0)";

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
                    MessageBox.Show("Đăng ký thành công!", "Thành công",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // tắt form đăng ký  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Đóng form đăng ký
            this.Close();
            _loginForm.Show();

        }

        private void btnHienMK_Click(object sender, EventArgs e)
        {

            txtPassWord.UseSystemPasswordChar = false;
            btnHienMK.Visible = false;
            btnAnMK.Visible = true;
        }

        private void btnAnMK_Click(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = true;
            btnHienMK.Visible = true;
            btnAnMK.Visible = false;
        }
    }
}
