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
        public int SoLuong { get; set; }
        public string DuongDanAnh { get; set; }

        
        public GioHangItem()
        {
            InitializeComponent();
            this.Load += GioHangItem_Load;
        }

        private void GioHangItem_Load(object sender, EventArgs e)
        {
            lblTen.Text = TenSanPham ?? "Không có tên";
            lblGia.Text = $"{Gia:N0} ₫";
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
            string query = @"DELETE FROM [QLBH].[dbo].[Cart]
            WHERE 
            [cart_id] = @id;";

            var bien = new[] {
            new SqlParameter("@id", CartId.ToString()),
            };
            DatabaseHelper.ExecuteScalar(query, bien);

            fHome homeForm = this.FindForm() as fHome;
            homeForm?.TaiGioHangTuSQL();

        }
    }
}