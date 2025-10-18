using Microsoft.Reporting.WinForms;
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
            lblGia.Text = Gia.ToString("N0") + " VND";
            lblSoLuongTonKho.Text = "Còn: " + SoLuongTonKho.ToString();
            txtProductDescription.Text = MoTaSP;

            // Hiển thị ảnh chính
            picAnhSP.ImageLocation = DuongDanAnh;

            // 3. Tải và hiển thị danh sách ảnh thumbnail
            HienThiListAnh(idSP);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.KiemTraDangNhap() == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập để thêm sản phẩm vào giỏ hàng.", "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper.ThemVaoGioHang(Convert.ToInt32(this.idSP), Convert.ToInt32(txtSoLuong.Text.Trim()));

        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
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
                    lblSoLuongTonKho.Text = "Còn: " + this.SoLuongTonKho.ToString();

                    
                }
                else
                {
                    MessageBox.Show(resultMessage, "Lỗi Đặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}