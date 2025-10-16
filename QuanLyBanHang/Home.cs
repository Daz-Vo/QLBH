using QuanLyBanHang.DAL;
using System;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace QuanLyBanHang
{
    public partial class fHome : Form
    {
        private string chuoiKetNoi = DatabaseHelper.GetConnection().ConnectionString;
        private fLogin fLogin; // Tham chiếu form đăng nhập
        // Lấy thông tin tk đăng nhập
        // Lưu ý: Việc gán giá trị biến static/tham chiếu ở đây có thể gây lỗi nếu fLogin chưa được khởi tạo hoàn toàn
        // Tuy nhiên, ta giả định fLogin.UserId và fLogin.QuyenUser đã có giá trị khi fHome được tạo
        public int ID_Dang_Nhap = fLogin.UserId;
        public int Admin = fLogin.QuyenUser;

        // Khai báo biến tongTien ở cấp độ class
        decimal tongTien = 0; // Biến này cần được reset trong TaiGioHangTuSQL()

        public fHome(fLogin loginForm)
        {
            this.fLogin = loginForm; // Lưu lại tham chiếu
            InitializeComponent();
            this.Load += fHome_Load;
            this.btnDatHang.Click += btnDatHang_Click; // Đảm bảo nút "Đặt hàng" có sự kiện
        }


        private async void fHome_Load(object sender, EventArgs e)
        {
            HienThiTK();
            await TaiDanhSachSanPham();
            await TaiGioHangTuSQL();

        }

        private void HienThiTK()
        {
            string user_id = ID_Dang_Nhap.ToString();

            string checkQuery1 = "SELECT username FROM Users WHERE user_id = @user_id";
            var checkParams1 = new[] { new SqlParameter("@user_id", user_id) };
            string[] result = DatabaseHelper.ExecuteQueryFirstRow(checkQuery1, checkParams1);

            if (ID_Dang_Nhap != 0)
            {
                txtTaiKhoan.Text = result[0];
                btnDangNhap.Visible = false;
                btnDangXuat.Visible = true;
            }
            if (Admin == 1)
            {
                btnAdmin.Visible = true;
            }

        }

        // === TẢI SẢN PHẨM ===
        private async Task TaiDanhSachSanPham()
        {
            flowPanelSanPham.Controls.Clear();
            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                string cauTruyVan = @"
                SELECT [product_name], [price], [product_id], [stock_quantity], [image_url]
                FROM [QLBH].[dbo].[Products]";

                SqlCommand lenh = new SqlCommand(cauTruyVan, ketNoi);
                ketNoi.Open();
                SqlDataReader doc = await Task.Run(() => lenh.ExecuteReader());

                while (doc.Read())
                {
                    string idSP = doc["product_id"].ToString();
                    string ten = doc["product_name"].ToString();
                    decimal gia = Convert.ToDecimal(doc["price"]);
                    int soLuongTon = Convert.ToInt32(doc["stock_quantity"]);
                    string anh = doc["image_url"].ToString();

                    var oSanPham = new SanPhamItem
                    {
                        idSP = idSP,
                        TenSanPham = ten,
                        Gia = gia,
                        SoLuongTonKho = soLuongTon,
                        DuongDanAnh = anh
                    };

                    oSanPham.Size = new Size(200, 280);
                    oSanPham.Margin = new Padding(10);
                    flowPanelSanPham.Controls.Add(oSanPham);
                }

                doc.Close();
            }
        }

        // === TẢI GIỎ HÀNG TỪ SQL (ĐÃ SỬA LỖI TỔNG TIỀN) ===
        public async Task TaiGioHangTuSQL()
        {
            flowPanelGioHang.Controls.Clear();

            // **FIX LỖI:** Reset tổng tiền về 0 trước khi tính toán lại.
            tongTien = 0;

            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                string cauTruyVan = @"
                    SELECT 
                        c.cart_id,
                        c.product_id,
                        c.quantity,
                        p.product_name,
                        p.price,
                        p.image_url
                    FROM [QLBH].[dbo].[Cart] c
                    INNER JOIN [QLBH].[dbo].[Products] p ON c.product_id = p.product_id
                    WHERE c.user_id = @UserId";

                SqlCommand lenh = new SqlCommand(cauTruyVan, ketNoi);
                lenh.Parameters.AddWithValue("@UserId", ID_Dang_Nhap);

                ketNoi.Open();
                SqlDataReader doc = await Task.Run(() => lenh.ExecuteReader());

                while (doc.Read())
                {
                    string idSP = doc["product_id"].ToString();
                    int cartId = Convert.ToInt32(doc["cart_id"]);
                    string ten = doc["product_name"].ToString();
                    decimal gia = Convert.ToDecimal(doc["price"]);
                    int soLuong = Convert.ToInt32(doc["quantity"]);
                    string anh = doc["image_url"].ToString();

                    var item = new GioHangItem
                    {
                        idSP = idSP,
                        TenSanPham = ten,
                        Gia = gia,
                        SoLuong = soLuong,
                        DuongDanAnh = anh,
                        CartId = cartId
                    };

                    item.Size = new Size(280, 100);
                    item.Margin = new Padding(5);


                    flowPanelGioHang.Controls.Add(item);
                    tongTien += gia * soLuong;
                }

                doc.Close();
            }

            lblTongTien.Text = $"Tổng: {tongTien:N0} ₫";
        }

        // === CẬP NHẬT SỐ LƯỢNG TRONG GIỎ HÀNG (SQL) ===
        private async Task CapNhatSoLuongTrongSQL(int cartId, int soLuongMoi)
        {
            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                string cauTruyVan = "UPDATE [QLBH].[dbo].[Cart] SET quantity = @SoLuong WHERE cart_id = @CartId";
                SqlCommand lenh = new SqlCommand(cauTruyVan, ketNoi);
                lenh.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                lenh.Parameters.AddWithValue("@CartId", cartId);
                ketNoi.Open();
                await Task.Run(() => lenh.ExecuteNonQuery());
            }
        }

        // === HÀM CẬP NHẬT TỒN KHO CỤC BỘ (MỚI) ===
        private void CapNhatTonKhoCucBo(List<int> productIds)
        {
            using (var QLDB = new QLDB_DB())
            {
                foreach (Control control in flowPanelSanPham.Controls)
                {
                    if (control is SanPhamItem sanPhamControl)
                    {
                        if (int.TryParse(sanPhamControl.idSP, out int currentProductId))
                        {
                            if (productIds.Contains(currentProductId))
                            {
                                // Lấy sản phẩm mới nhất từ DB
                                var product = QLDB.Products.FirstOrDefault(p => p.product_id == currentProductId);

                                if (product != null)
                                {
                                    sanPhamControl.SoLuongTonKho = product.stock_quantity;
                                    sanPhamControl.CapNhatGiaoDienTonKho();
                                }
                            }
                        }
                    }
                }
            }
        }


        // === ĐẶT HÀNG (ĐÃ CẬP NHẬT LOGIC EF & CẬP NHẬT UI CỤC BỘ) ===
        private async void btnDatHang_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.KiemTraDangNhap() == 0)
            {
                MessageBox.Show("Vui lòng đăng nhập.", "Chưa đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userid = ID_Dang_Nhap;

            // Danh sách lưu trữ ID sản phẩm đã mua
            var purchasedProductIds = new List<int>();

            using (var QLDB = new QLDB_DB())
            using (var transaction = QLDB.Database.BeginTransaction()) // Bắt đầu Transaction
            {
                try
                {
                    // 1. LẤY DỮ LIỆU GIỎ HÀNG VÀ KIỂM TRA
                    var gioHang = await Task.Run(() =>
                        QLDB.Carts
                            .Where(c => c.user_id == userid)
                            .ToList()
                    );

                    if (!gioHang.Any())
                    {
                        MessageBox.Show("Giỏ hàng trống! Không thể đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    // Lấy thông tin user (để có địa chỉ)
                    var user = await Task.Run(() => QLDB.Users.FirstOrDefault(u => u.user_id == userid));

                    // **FIX 1: Xử lý địa chỉ giao hàng (shipping_address)**
                    string diaChiGiaoHang = user?.address;
                    if (string.IsNullOrWhiteSpace(diaChiGiaoHang))
                    {
                        // Cần gán một giá trị mặc định nếu địa chỉ của user bị NULL hoặc trống
                        diaChiGiaoHang = "Địa chỉ chưa cập nhật";
                        MessageBox.Show("Vui lòng cập nhật địa chỉ giao hàng trong hồ sơ tài khoản!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // **FIX 2: Xử lý trạng thái đơn hàng (order_status)**
                    string trangThaiDonHang = "Chờ xử lý"; // Gán giá trị mặc định

                    

                    // 2. TẠO ORDER CHÍNH (Với tổng tiền tạm thời)
                    var newOrder = new Order
                    {
                        user_id = userid,
                        order_date = DateTime.Now,
                        total_amount = 0, // Sẽ tính lại sau
                        shipping_address = diaChiGiaoHang,
                        order_status = trangThaiDonHang
                    };
                    QLDB.Orders.Add(newOrder);
                    await QLDB.SaveChangesAsync(); // Lưu lần 1 để lấy Order ID

                    decimal finalTotal = 0; // Tổng tiền chính xác sẽ được tính khi lặp

                    // 3. TẠO ORDER ITEMS & CẬP NHẬT TỒN KHO
                    foreach (var item in gioHang)
                    {
                        var product = await Task.Run(() => QLDB.Products.FirstOrDefault(p => p.product_id == item.product_id));

                        if (product == null || product.stock_quantity < item.quantity)
                        {
                            MessageBox.Show($"Lỗi: Sản phẩm '{product?.product_name}' không đủ tồn kho ({product?.stock_quantity} còn lại).", "Lỗi đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        // Tạo Order Item
                        var orderItem = new Order_Items
                        {
                            order_id = newOrder.order_id,
                            product_id = item.product_id,
                            quantity = item.quantity,
                            price_per_item = product.price
                        };
                        QLDB.Order_Items.Add(orderItem);

                        // Cập nhật tồn kho
                        product.stock_quantity -= item.quantity;
                        finalTotal += (item.quantity * product.price);

                        // Lưu ID sản phẩm đã mua
                        purchasedProductIds.Add(item.product_id);
                    }

                    // Cập nhật lại tổng tiền chính xác cho Order chính
                    newOrder.total_amount = finalTotal;

                    // 4. XÓA GIỎ HÀNG
                    QLDB.Carts.RemoveRange(gioHang);

                    // 5. LƯU CÁC THAY ĐỔI CÒN LẠI VÀ COMMIT
                    await QLDB.SaveChangesAsync();
                    transaction.Commit();

                    MessageBox.Show("Đặt hàng thành công! Đơn hàng đang chờ xử lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbEntityValidationException ex)
                {
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
                    transaction.Rollback();
                    MessageBox.Show($"Đã xảy ra lỗi trong quá trình đặt hàng: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Tải lại giỏ hàng (sẽ trống)
            await TaiGioHangTuSQL();

            // CẬP NHẬT TỒN KHO CỤC BỘ TRÊN GIAO DIỆN SẢN PHẨM
            CapNhatTonKhoCucBo(purchasedProductIds);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            if (ID_Dang_Nhap == 0)
            {
                MessageBox.Show("Chưa đăng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Giả định MyAccout có sẵn
             MyAccout myAccout = new MyAccout();
             myAccout.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Giả định fAdmin có sẵn
            fAdmin admin = new fAdmin();
          
            admin.ShowDialog();
        }


    }
}