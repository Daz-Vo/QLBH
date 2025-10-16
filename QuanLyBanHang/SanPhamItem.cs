using QuanLyBanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static QuanLyBanHang.DatabaseHelper;
using System.Data.Entity.Validation;



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

            string query = @"IF EXISTS (
       SELECT 1 
    FROM [QLBH].[dbo].[Cart]
    WHERE [user_id] = @UserID AND [product_id] = @ProductID
)
BEGIN
        UPDATE [QLBH].[dbo].[Cart]
    SET 
        [quantity] = [quantity] + @QuantityToAdd,
        [added_date] = GETDATE()     WHERE 
        [user_id] = @UserID AND [product_id] = @ProductID;
END
ELSE
BEGIN
        INSERT INTO [QLBH].[dbo].[Cart] 
    (
        [user_id], 
        [product_id], 
        [quantity], 
        [added_date]
    )
    VALUES 
    (
        @UserID, 
        @ProductID, 
        @QuantityToAdd, 
        GETDATE()
    );
END";

            var bien = new[] {
                new SqlParameter("@UserID", fLogin.UserId.ToString()),
                 new SqlParameter("@ProductID", idSP),
                  new SqlParameter("@QuantityToAdd", txtSoLuong.Text.Trim())

            };
            DatabaseHelper.ExecuteScalar(query, bien);

            // Load lại giỏ hàng
            fHome homeForm = this.FindForm() as fHome;
            homeForm?.TaiGioHangTuSQL();
        }

        private void btnMuaNgay_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.KiemTraDangNhap() == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập.", "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin đầu vào
            int userid = fLogin.UserId;
            int idSP = Convert.ToInt32(this.idSP);
            int SoLuongMua = Convert.ToInt32(txtSoLuong.Text.Trim());

            using (var QLDB = new QLDB_DB())
            {
                // 1. LẤY DỮ LIỆU CẦN THIẾT
                var user = QLDB.Users.FirstOrDefault(u => u.user_id == userid);
                var product = QLDB.Products.FirstOrDefault(p => p.product_id == idSP);

                // 2. KIỂM TRA DỮ LIỆU (Pre-validation)
                if (user == null)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy thông tin người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SanPhamItem_Load(sender, e);
                    return;
                }
                if (product == null)
                {
                    MessageBox.Show("Lỗi: Sản phẩm không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SanPhamItem_Load(sender, e);
                    return;
                }
                if (product.stock_quantity < SoLuongMua)
                {
                    MessageBox.Show("Lỗi: Số lượng tồn kho không đủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SanPhamItem_Load(sender, e);
                    return;
                }

                // --- BẮT ĐẦU TRANSACTION CHỈ KHI DỮ LIỆU ĐÃ HỢP LỆ ---
                using (var transaction = QLDB.Database.BeginTransaction())
                {
                    try
                    {
                        // 3. TÍNH TOÁN VÀ XỬ LÝ DỮ LIỆU
                        decimal DonGia = product.price; // Lấy đơn giá từ Product
                        decimal TongTien = SoLuongMua * DonGia;
                        int SoLuongConLai = product.stock_quantity - SoLuongMua;
                        DateTime NgayMua = DateTime.Now;

                        // FIX LỖI 1 (shipping_address): Đảm bảo giá trị không NULL/rỗng
                        string DiaChiGiaoHang = user.address;
                        if (string.IsNullOrWhiteSpace(DiaChiGiaoHang))
                        {
                            DiaChiGiaoHang = "Địa chỉ chưa cập nhật";
                            // Tùy chọn: Thông báo cho người dùng
                        }

                        // FIX LỖI 2 (order_status): Đảm bảo giá trị luôn hợp lệ
                        string TrangThaiDonHang = "Đã xác nhận đơn hàng";


                        // 4. TẠO VÀ LƯU ORDER (Lưu lần 1: Lấy Order.order_id)
                        var Order = new Order
                        {
                            user_id = userid,
                            order_date = NgayMua,
                            total_amount = TongTien,
                            shipping_address = DiaChiGiaoHang, // Đã được xử lý NULL
                            order_status = TrangThaiDonHang   // Đã được gán giá trị
                        };
                        QLDB.Orders.Add(Order);
                        QLDB.SaveChanges(); // <-- LƯU LẦN 1: Lấy Order.order_id

                        // 5. TẠO VÀ LƯU ORDER_ITEMS
                        var Order_Items = new Order_Items
                        {
                            order_id = Order.order_id,
                            product_id = idSP,
                            quantity = SoLuongMua,
                            price_per_item = DonGia // Đơn giá tại thời điểm mua
                        };
                        QLDB.Order_Items.Add(Order_Items);

                        // 6. CẬP NHẬT TỒN KHO
                        product.stock_quantity = SoLuongConLai;

                        // 7. LƯU CÁC THAY ĐỔI CÒN LẠI VÀ COMMIT TRANSACTION
                        QLDB.SaveChanges(); // <-- LƯU LẦN 2: Order_Items và Product
                        transaction.Commit();

                        MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.SoLuongTonKho = SoLuongConLai; //cập nhật lại số lượng tồn kho trên giao diện
                    }
                    catch (DbEntityValidationException ex)
                    {
                        // Lỗi này bắt lỗi xác thực (validation) như lỗi bạn gặp trước đó
                        transaction.Rollback();

                        var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => $"{x.PropertyName}: {x.ErrorMessage}");

                        var fullErrorMessage = string.Join("\n", errorMessages);

                        var exceptionMessage = $"Lỗi xác thực dữ liệu:\n{fullErrorMessage}";

                        MessageBox.Show(exceptionMessage, "Lỗi xác thực Entity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Bắt các lỗi khác (lỗi DB, lỗi kết nối, lỗi logic chưa kiểm tra)
                        transaction.Rollback();
                        MessageBox.Show($"Đã xảy ra lỗi trong quá trình đặt hàng: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // End Transaction
            } // End DbContext

            // GỌI SanPhamItem_Load MỘT LẦN KHI KẾT THÚC HÀM
            SanPhamItem_Load(sender, e);

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
    }
}