using QuanLyBanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static QuanLyBanHang.DatabaseHelper;
using static QuanLyBanHang.fChiTietSP;



namespace QuanLyBanHang
{


    public partial class SanPhamItem : UserControl
    {
        // Các thuộc tính để nhận dữ liệu từ bên ngoài
        public string TenSanPham { get; set; }
        public decimal Gia { get; set; }
        public int SoLuongTonKho { get; set; }
        public string DuongDanAnh { get; set; }
        public string idSP { get; set; }
        public string userid { get; set; }


        public SanPhamItem()
        {
            InitializeComponent();
            this.Load += SanPhamItem_Load; // Đăng ký sự kiện Load

            // Đăng ký sự kiện MouseEnter, MouseLeave
            this.MouseEnter += (s, e) => this.BackColor = Color.AliceBlue;
            this.MouseLeave += (s, e) => this.BackColor = Color.White;
            
        }


        private void SanPhamItem_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Padding = new Padding(8);

            // Gán dữ liệu vào các Label
            lblTen.Text = TenSanPham ?? "Không có tên";
            lblGia.Text = $"{Gia:N0} ₫";
            lblSoLuong.Text = $"Còn: {SoLuongTonKho}";

            CapNhatGiaoDienTonKho();

            // Tải ảnh
            if (!string.IsNullOrEmpty(DuongDanAnh))
            {
                try
                {
                    if (DuongDanAnh.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                    {
                        using (WebClient wc = new WebClient())
                        {
                            byte[] data = wc.DownloadData(DuongDanAnh);
                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                picAnh.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else if (File.Exists(DuongDanAnh))
                    {
                        picAnh.Image = Image.FromFile(DuongDanAnh);
                    }
                    else
                    {
                        picAnh.BackColor = Color.LightGray;
                    }
                }
                catch
                {
                    picAnh.BackColor = Color.LightGray;
                }
            }
            else
            {
                picAnh.BackColor = Color.LightGray;
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.KiemTraDangNhap() == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập để thêm sản phẩm vào giỏ hàng.", "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper.ThemVaoGioHang(Convert.ToInt32(this.idSP), Convert.ToInt32(txtSoLuong.Text.Trim()));

            // Load lại giỏ hàng
            fHome homeForm = this.FindForm() as fHome;
            homeForm?.TaiGioHangTuSQL();
        }

        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đăng nhập
            if (DatabaseHelper.KiemTraDangNhap() == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập.", "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy thông tin đầu vào
            int userId = fLogin.UserId;
            int productId;
            int soLuongMua;

            // Đảm bảo các giá trị được chuyển đổi hợp lệ
            if (!int.TryParse(this.idSP.ToString(), out productId))
            {
                MessageBox.Show("Lỗi định dạng ID sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuongMua))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. GỌI HÀM SERVICE
            string resultMessage = OrderService.MuaNgay(userId, productId, soLuongMua);

            // 4. XỬ LÝ KẾT QUẢ VÀ CẬP NHẬT GIAO DIỆN
            if (resultMessage == "Đặt hàng thành công!")
            {
                MessageBox.Show(resultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật tồn kho trên giao diện sau khi thành công
                this.SoLuongTonKho -= soLuongMua;
                lblSoLuong.Text = "Còn: " + this.SoLuongTonKho.ToString();

                // Gọi lại hàm load để cập nhật dữ liệu nếu cần
                // SanPhamItem_Load(sender, e); // Chỉ gọi nếu cần làm mới toàn bộ form
            }
            else
            {
                MessageBox.Show(resultMessage, "Lỗi Đặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CapNhatGiaoDienTonKho()
        {
            // Cập nhật lại Label SoLuong dựa trên thuộc tính SoLuongTonKho
            lblSoLuong.Text = $"Còn: {SoLuongTonKho}";

            // Tùy chọn: Thay đổi màu sắc nếu hết hàng
            if (SoLuongTonKho <= 0)
            {
                lblSoLuong.ForeColor = Color.Red;
            }
            else
            {
                lblSoLuong.ForeColor = Color.Black;
            }
        }

        private void picAnh_Click(object sender, EventArgs e)
        {
            fChiTietSP fChiTietSP = new fChiTietSP();
            fChiTietSP.idSP = Convert.ToInt32(this.idSP);
            fChiTietSP.userid = fLogin.UserId.ToString();
            fChiTietSP.ShowDialog();
        }
        

    }
}