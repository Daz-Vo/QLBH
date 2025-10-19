using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class GioHangItem : UserControl
    {
       
        public int CartId { get; set; }
        public string TenSanPham { get; set; }
        public string idSP { get; set; }
        public decimal Gia { get; set; }
        private int _soLuong;

        // Giả sử numSoLuong là control hiển thị số lượng (TextBox, Label, NumericUpDown)
        public int SoLuong
        {
            get { return _soLuong; }
            set
            {
                _soLuong = value;
                // Cập nhật control giao diện ngay khi thuộc tính thay đổi
                if (numSoLuong != null) // Đảm bảo control đã được khởi tạo
                {
                    // Dùng .Text nếu là Label/TextBox, dùng .Value nếu là NumericUpDown
                    numSoLuong.Text = value.ToString(); // Hoặc numSoLuong.Value = value;
                }
            }
        }

        public string DuongDanAnh { get; set; }

        
        public GioHangItem()
        {
            InitializeComponent();
            this.Load += GioHangItem_Load;
        }

        private void GioHangItem_Load(object sender, EventArgs e)
        {
            lblTen.Text = TenSanPham ?? "Không có tên";
            lblGia.Text = $"{Gia:N0} VNĐ";
            numSoLuong.Value = SoLuong;

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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            fHome homeForm = this.FindForm() as fHome;
            homeForm?.Xoa_1SP_KhoiGH(CartId);
        }
    }
}