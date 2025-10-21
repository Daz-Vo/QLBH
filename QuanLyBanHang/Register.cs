using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace QuanLyBanHang
{
    public partial class fRegister : Form
    {
        private fLogin _loginForm;
        private Dictionary<TextBox, string> placeholders = new Dictionary<TextBox, string>();

        public fRegister(fLogin loginForm)
        {
            InitializeComponent();
            this._loginForm = loginForm;
        }


        private string GetValue(TextBox txt)
        {
            if (txt.ForeColor == Color.Gray && txt.Text == placeholders[txt])
                return "";
            return txt.Text.Trim();
        }

        // ==========================
        // NÚT ĐĂNG KÝ
        // ==========================
        private void txtRegister_Click(object sender, EventArgs e)
        {
            string username = GetValue(txtUserName);
            string password = GetValue(txtPassWord);
            string fullname = GetValue(txtFull_Name);
            string phone = GetValue(txtPhone_Number);
            string email = GetValue(txtEmail);
            string address = GetValue(txtAddress);

            // 1️⃣ Kiểm tra trống
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(fullname) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Vui lòng không để trống thông tin!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2️⃣ Họ tên ≥ 3 ký tự
            if (fullname.Length < 3)
            {
                MessageBox.Show("Họ tên phải có ít nhất 3 ký tự!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFull_Name.Focus();
                return;
            }

            // 3️⃣ Mật khẩu ≥ 6 ký tự
            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassWord.Focus();
                return;
            }
            //Mật khẩu phải có chữ thường, chữ hoa, số và ký tự đặc biệt
            bool hasLower = Regex.IsMatch(password, "[a-z]");
            bool hasUpper = Regex.IsMatch(password, "[A-Z]");
            bool hasDigit = Regex.IsMatch(password, "[0-9]");
            bool hasSpecial = Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]");

            if (!hasLower || !hasUpper || !hasDigit || !hasSpecial)
            {
                MessageBox.Show("Mật khẩu bao gồm:\n- Chữ thường: abc...\n- Chữ hoa: ABC...\n- Số: 123...\n- Ký tự đặc biệt: @!#$...",
                                "Mật khẩu yếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassWord.Focus();
                return;
            }

            //Kiểm tra đầu số SĐT hợp lệ (theo nhà mạng VN)
            string regexVNPhone = @"^(03[2-9]|05[5|6|8|9]|07[0-9]|08[1-9]|09[0-9])\d{7}$";
            if (!Regex.IsMatch(phone, regexVNPhone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập đúng đầu số của Việt Nam.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone_Number.Focus();
                return;
            }

            // 4️⃣ SĐT = 10 số
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone_Number.Focus();
                return;
            }
            // 5️⃣ Email đúng định dạng @gmail.com
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập dạng: ten@gmail.com", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // 6️⃣ Kiểm tra username trùng
            string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
            var userParams = new[] { new SqlParameter("@username", username) };

            try
            {
                int userCount = (int)DatabaseHelper.ExecuteScalar(checkUserQuery, userParams);
                if (userCount > 0)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại! Vui lòng chọn tên khác.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.SelectAll();
                    txtUserName.Focus();
                    return;
                }

                // 7️⃣ Kiểm tra SĐT trùng
                string checkPhoneQuery = "SELECT COUNT(*) FROM Users WHERE phone_number = @phone";
                var phoneParams = new[] { new SqlParameter("@phone", phone) };
                int phoneCount = (int)DatabaseHelper.ExecuteScalar(checkPhoneQuery, phoneParams);

                if (phoneCount > 0)
                {
                    MessageBox.Show("Số điện thoại này đã được đăng ký, vui lòng dùng số khác.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone_Number.SelectAll();
                    txtPhone_Number.Focus();
                    return;
                }

                // 8️⃣ Lưu vào database
                string insertQuery = @"
                    INSERT INTO Users (username, password, email, full_name, phone_number, address, authority) 
                    VALUES (@username, @password, @email, @fullname, @phone, @address, 0)";

                var insertParams = new[]
                {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", DatabaseHelper.HashPassword(password)),
     

                    new SqlParameter("@email", email),
                    new SqlParameter("@fullname", fullname),
                    new SqlParameter("@phone", phone),
                    new SqlParameter("@address", address)
                };

                int rows = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

                if (rows > 0)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thành công",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _loginForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        // ==========================
        // NÚT QUAY LẠI ĐĂNG NHẬP
        // ==========================
        private void btnLogin_Click(object sender, EventArgs e)
        {
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
