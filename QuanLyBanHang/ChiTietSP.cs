using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyBanHang.DatabaseHelper;


namespace QuanLyBanHang
{
    public partial class fChiTietSP : Form
    {

        public event EventHandler YeuCauThemSP;
        public event EventHandler YeuCauCapNhatTonKho;

        public class CapNhatTonKhoArgs : EventArgs
        {
            public string ProductId { get; set; }
            public int QuantitySold { get; set; }
        }

        public fChiTietSP()
        {
            InitializeComponent();
        }

        // --- CÁC THUỘC TÍNH SẢN PHẨM (Properties) ---
        public string TenSanPham { get; set; }
        public decimal Gia { get; set; }
        public int SoLuongTonKho { get; set; }
        public string DuongDanAnh { get; set; } // Ảnh chính (từ cột image_url cũ của bảng Product)
        public int idSP { get; set; }
        public string userid { get; set; }
        public string MoTaSP { get; set; }

        // --- LOGIC TẢI DỮ LIỆU CHÍNH TỪ BẢNG PRODUCT ---
        private void LayDuLieuSP(int idSP)
        {
            using (var QLDB_DB = new QLDB_DB())
            {
                // Sử dụng .FirstOrDefault để lấy sản phẩm dựa trên ID
                var product = QLDB_DB.Products.FirstOrDefault(p => p.product_id == idSP);
                if (product != null)
                {
                    TenSanPham = product.product_name;
                    Gia = product.price;
                    SoLuongTonKho = product.stock_quantity;
                    DuongDanAnh = product.image_url; // Lấy ảnh chính
                    MoTaSP = product.description;
                }
            }
        }

        // --- LOGIC HIỂN THỊ DANH SÁCH ẢNH THUMBNAIL (MỚI) ---

        // Hàm tạo một PictureBox thumbnail từ URL
        private PictureBox CreateThumbnail(string url)
        {
            PictureBox thumb = new PictureBox();

            // Cấu hình kích thước và kiểu dáng cho thumbnail
            thumb.Size = new Size(60, 60);
            thumb.SizeMode = PictureBoxSizeMode.Zoom;
            thumb.BorderStyle = BorderStyle.FixedSingle;
            thumb.Cursor = Cursors.Hand;

            // Tải ảnh (sử dụng ImageLocation cho URL)
            thumb.ImageLocation = url;

            // Sự kiện nhấp chuột: Đặt ảnh này làm ảnh chính (picAnhSP)
            thumb.Click += (sender, e) => picAnhSP.ImageLocation = url;

            return thumb;
        }

        // Hàm tải và hiển thị tất cả ảnh phụ
        private void HienThiListAnh(int productId)
        {
            // Xóa các thumbnail cũ
            flowPanelThumbnails.Controls.Clear();

            try
            {
                using (var QLDB_DB = new QLDB_DB())
                {
                    // Truy vấn tất cả các URL ảnh từ bảng ListAnhSP
                    var imageUrls = QLDB_DB.ListAnhSPs
                                            .Where(img => img.product_id == productId)
                                            .Select(img => img.image_url)
                                            .ToList();

                    if (imageUrls == null || imageUrls.Count == 0)
                    {
                        return;
                    }

                    // Tạo và hiển thị các ảnh thumbnail
                    foreach (string url in imageUrls)
                    {
                        PictureBox thumbnail = CreateThumbnail(url);
                        flowPanelThumbnails.Controls.Add(thumbnail);
                    }
                }
            }
            catch (Exception ex)
            {
                // Nên ghi log chi tiết hơn
                MessageBox.Show("Lỗi khi tải danh sách ảnh: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- SỰ KIỆN LOAD FORM ---
        private void fChiTietSP_Load(object sender, EventArgs e)
        {
            // 1. Tải dữ liệu sản phẩm chính
            LayDuLieuSP(idSP);

            // 2. Hiển thị dữ liệu chính lên Controls
            lblTenSP.Text = "Tên Sản Phẩm: " + TenSanPham;
            lblGia.Text = Gia.ToString("N0") + " VNĐ";
            lblSoLuongTonKho.Text = "Còn: " + SoLuongTonKho.ToString();
            txtProductDescription.Text = MoTaSP;

            // Hiển thị ảnh chính
            picAnhSP.ImageLocation = DuongDanAnh;

            // 3. Tải và hiển thị danh sách ảnh thumbnail
            HienThiListAnh(idSP);
        }

        // TRONG FILE fChiTietSP.cs (hoặc Form con)

        // TRONG FILE fChiTietSP.cs (Form con)

        // Đảm bảo Form con đã có event này: public event EventHandler YeuCauThemSP;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // LẤY DỮ LIỆU CẦN THIẾT
            int productId = Convert.ToInt32(this.idSP);
            int quantity = Convert.ToInt32(txtSoLuong.Text.Trim()); // Giả sử có txtSoLuong

            // 1. Kiểm tra Đăng nhập
            if (DatabaseHelper.KiemTraDangNhap() == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập.", "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. THÊM VÀO DATABASE VÀ TRỪ TỒN KHO
            // Logic này phải được gọi trước khi kích hoạt Event và đóng Form.
            DatabaseHelper.ThemVaoGioHang(productId, quantity);

            // **Nếu CapNhatTonKho là static, gọi trực tiếp:**
            // DatabaseHelper.CapNhatTonKho(productId, quantity); 

            // 3. KÍCH HOẠT EVENT: Báo Form cha cập nhật giỏ hàng
            YeuCauThemSP?.Invoke(this, EventArgs.Empty);

            // 4. Đóng Form con
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            // 1. Kiem tra dang nhap
            if (DatabaseHelper.KiemTraDangNhap() == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập.", "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //đặt hàng vào data
            DatabaseHelper.MuaNgay1SP(Convert.ToInt16(userid), idSP, Convert.ToInt16(txtSoLuong.Text));

            // 3. KÍCH HOẠT EVENT
            YeuCauCapNhatTonKho?.Invoke(this, EventArgs.Empty);
            

            // 4. Đóng Form con
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int CapNhatKho()
        {
            return SoLuongTonKho = SoLuongTonKho - Convert.ToInt16(txtSoLuong.Text);  ;
        }
    }
}