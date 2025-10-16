using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class fLogin : Form
    {

        // Biến static, có thể truy cập từ mọi nơi
        public static int UserId;
        public static int QuyenUser;


        public static int LayIDuser(string username, string password)
        {
            string query = "SELECT user_id FROM dbo.Users WHERE username = @user AND password = @pass";
            var parameters = new[]
            {
                new SqlParameter("@user", username),
                new SqlParameter("@pass", password)
            };
            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            if (result != null && int.TryParse(result.ToString(), out int userId))
            {
                return userId;
            }
            return 0; // Trả về 0 nếu không tìm thấy
        }

        public static int LayQuyenuser(string username, string password)
        {
            string query = "SELECT authority FROM dbo.Users WHERE username = @user AND password = @pass";
            var parameters = new[]
            {
                new SqlParameter("@user", username),
                new SqlParameter("@pass", password)
            };
            object result = DatabaseHelper.ExecuteScalar(query, parameters);

            if (result != null && int.TryParse(result.ToString(), out int authority))
            {
                return authority;
            }
            return 0; // Trả về 0 nếu không tìm thấy
        }




        public fLogin()
        {
            InitializeComponent();         
            fHome homeForm = new fHome(this);
            homeForm.ShowDialog();
            this.AcceptButton = btnLogin; // Đặt nút đăng nhập làm nút mặc định
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                string username = txtUserName.Text;
                string password = txtPassWord.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!");
                    return;
                }
                

                string query = "SELECT COUNT(*) FROM Users WHERE username = @user AND password = @pass";
                var parameters = new[]
                {
                new SqlParameter("@user", username),
                new SqlParameter("@pass", password)
                };

                int count = (int)DatabaseHelper.ExecuteScalar(query, parameters);
                if (count > 0)
                {
                
                // Lấy UserId và gán vào biến static
                UserId = LayIDuser(username, password);
                QuyenUser = LayQuyenuser(username, password);
                // hiển thi fHome
                this.Hide();
                fHome fHome = new fHome(this);
                    fHome.Show();
                    
                    
                   
                    
            }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }

            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegister fRegister = new fRegister(this);
            fRegister.Show();
            

        }


    }

}
