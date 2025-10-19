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
        public decimal tongTien = 0; // Biến này cần được reset trong TaiGioHangTuSQL()

        public fHome(fLogin loginForm)
        {
            this.fLogin = loginForm; // Lưu lại tham chiếu
            InitializeComponent();
            this.Load += fHome_Load;
            this.btnDatHang.Click += btnDatHang_Click; // Đảm bảo nút "Đặt hàng" có sự kiện
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fHome_FormClosing);
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra câu trả lời của người dùng
            if (ID_Dang_Nhap != 0)
            {
                System.Windows.Forms.Application.Exit();
            }
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
                btnLoadLaisp.Visible = true;
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


                    
                    oSanPham.Margin = new Padding(5);
                    flowPanelSanPham.Controls.Add(oSanPham);
                }

                doc.Close();
            }
            flowDienThoai.Controls.Clear();

            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                string cauTruyVan = @"

                SELECT [product_name], [price], [product_id], [stock_quantity], [image_url]

                FROM [QLBH].[dbo].[Products]

where [category_id] = N'Điện thoại'";

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


                   
                    oSanPham.Margin = new Padding(5);
                    flowDienThoai.Controls.Add(oSanPham);
                }

                doc.Close();
            }
        }

        // === TẢI GIỎ HÀNG TỪ SQL (ĐÃ SỬA LỖI TỔNG TIỀN) ===
        public async Task TaiGioHangTuSQL()
        {

            flowPanelGioHang.Controls.Clear();
            // **FIX LỖI:** Reset tổng tiền về 0 trước khi tính toán lại.
            tongTien = 0; // Giữ nguyên reset biến tổng tiền

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

                try
                {
                    // Nên dùng OpenAsync() và ExecuteReaderAsync() nếu có thể
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
                                          
                        item.Margin = new Padding(5);

                        // ĐĂNG KÝ SỰ KIỆN: Khi item bị xóa, gọi hàm CapNhatTongTien()
    

                        flowPanelGioHang.Controls.Add(item);

                        // Giữ nguyên logic tính tổng tiền (tongTien)
                        // để đảm bảo tongTien chứa tổng giá trị sau khi tải
                        tongTien += gia * soLuong;
                    }

                    doc.Close();
                }
                catch (Exception )
                {
                    // Xử lý lỗi
                }
            }

            // GỌI HÀM MỚI ĐỂ GÁN TỔNG TIỀN VÀO LABEL
            CapNhatTongTien();
        }
        /// <summary>
        /// Tính toán lại tổng tiền dựa trên các item hiện có trong flowPanelGioHang 
        /// và gán giá trị vào lblTongTien.
        /// </summary>
 
        public void CapNhatTongTien()
        {
            decimal tongTienMoi = 0;
            // Lặp qua tất cả các control là GioHangItem trong panel
            foreach (GioHangItem item in flowPanelGioHang.Controls.OfType<GioHangItem>())
            {
                // Sử dụng thuộc tính Gia và SoLuong đã được gán khi tải
                tongTienMoi += item.Gia * item.SoLuong;
            }

            // Cập nhật biến tongTien của lớp
            tongTien = tongTienMoi;

            // Gán vào Label hiển thị
            lblTongTien.Text = $"Tổng: {tongTien:N0} VNĐ";
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

        public async Task Tai_1SP_VaoGH(string idSPCanTai)
        {
            // KHÔNG reset tongTien = 0; nữa, vì bạn muốn cộng dồn.
            // Nếu sản phẩm đã tồn tại, logic này sẽ gây ra lỗi cộng dồn.
            // Tốt hơn hết, bạn nên làm như sau:

            // 1. Dùng hàm này để TẢI DỮ LIỆU CỦA SẢN PHẨM MỚI TỪ DB.
            // 2. TÌM xem sản phẩm đó đã có trong flowPanelGioHang chưa.
            // 3. Nếu có, CẬP NHẬT số lượng và TRỪ tổng tiền cũ rồi CỘNG tổng tiền mới.
            // 4. Nếu chưa, THÊM control mới và CỘNG thẳng vào tổng tiền.

            decimal tongTienCu = tongTien; // Lưu lại tổng tiền ban đầu để tính toán lại sau
            decimal giaTriThayDoi = 0; // Số tiền sẽ được cộng/trừ vào tổng tiền

            // BƯỚC 1: LỌC VÀ TRUY VẤN SẢN PHẨM CỤ THỂ
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
            WHERE c.user_id = @UserId AND c.product_id = @ProductId"; // <-- Lọc theo product_id

                SqlCommand lenh = new SqlCommand(cauTruyVan, ketNoi);
                lenh.Parameters.AddWithValue("@UserId", ID_Dang_Nhap);
                lenh.Parameters.AddWithValue("@ProductId", idSPCanTai); // <-- Thêm tham số lọc

                try
                {
                    await ketNoi.OpenAsync();
                    SqlDataReader doc = await lenh.ExecuteReaderAsync();

                    // BƯỚC 2: XỬ LÝ KẾT QUẢ TRUY VẤN
                    if (doc.Read()) // Chỉ đọc một kết quả
                    {
                        string idSP = doc["product_id"].ToString();
                        int cartId = Convert.ToInt32(doc["cart_id"]);
                        string ten = doc["product_name"].ToString();
                        decimal gia = Convert.ToDecimal(doc["price"]);
                        int soLuongMoi = Convert.ToInt32(doc["quantity"]);
                        string anh = doc["image_url"].ToString();

                        // 2.1: TÌM KIẾM ITEM ĐÃ TỒN TẠI TRONG GIAO DIỆN CHƯA
                        GioHangItem itemHienTai = flowPanelGioHang.Controls
                            .OfType<GioHangItem>()
                            .FirstOrDefault(i => i.idSP == idSP);

                        if (itemHienTai != null)
                        {
                            // ĐÃ TỒN TẠI (Update số lượng)

                            // ... (Tính toán tổng tiền)
                            decimal giaTriCu = itemHienTai.Gia * itemHienTai.SoLuong;
                            decimal giaTriMoi = gia * soLuongMoi;

                            // Cập nhật thuộc tính đối tượng C#
                            itemHienTai.SoLuong = soLuongMoi;
                            itemHienTai.CartId = cartId;

                            // Tính toán chênh lệch tổng tiền
                            giaTriThayDoi = giaTriMoi - giaTriCu;
                        }
                        else
                        {
                            // CHƯA TỒN TẠI (Thêm mới)

                            var itemMoi = new GioHangItem
                            {
                                idSP = idSP,
                                TenSanPham = ten,
                                Gia = gia,
                                SoLuong = soLuongMoi,
                                DuongDanAnh = anh,
                                CartId = cartId
                            };

                            
                            itemMoi.Margin = new Padding(5);

                            flowPanelGioHang.Controls.Add(itemMoi);

                            // Tính toán giá trị mới để cộng vào tổng tiền
                            giaTriThayDoi = gia * soLuongMoi;
                        }
                    }

                    doc.Close();
                }
                catch (Exception )
                {
                    // Xử lý lỗi
                }
            }

            // BƯỚC 3: CẬP NHẬT TỔNG TIỀN CUỐI CÙNG
            // tongTien = tổng tiền hiện tại + giá trị thay đổi
            CapNhatTongTien();
        }
        public async Task Xoa_1SP_KhoiGH(int cartIdCanXoa)
        {
            // BƯỚC 1: XÓA KHỎI DATABASE
            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                string cauTruyVan = @"
            DELETE FROM [QLBH].[dbo].[Cart]
            WHERE [cart_id] = @CartId";

                SqlCommand lenh = new SqlCommand(cauTruyVan, ketNoi);
                lenh.Parameters.AddWithValue("@CartId", cartIdCanXoa);

                try
                {
                    await ketNoi.OpenAsync();
                    // Sử dụng ExecuteNonQueryAsync vì đây là lệnh DELETE
                    await lenh.ExecuteNonQueryAsync();
                }
                catch (Exception)
                {
                    // Xử lý lỗi (ví dụ: lỗi không thể kết nối DB)
                    return; // Dừng lại nếu không xóa được khỏi DB
                }
            }

            // BƯỚC 2: XÓA KHỎI GIAO DIỆN

            // 2.1: TÌM KIẾM ITEM ĐÃ TỒN TẠI TRONG GIAO DIỆN CHƯA
            // Chúng ta tìm GioHangItem dựa trên CartId
            GioHangItem itemCanXoa = flowPanelGioHang.Controls
                .OfType<GioHangItem>()
                .FirstOrDefault(i => i.CartId == cartIdCanXoa); // Giả sử CartId là thuộc tính của GioHangItem

            if (itemCanXoa != null)
            {
                // Lấy tham chiếu đến panel cha (flowPanelGioHang)
                System.Windows.Forms.Control parentPanel = itemCanXoa.Parent;

                // 2.2: LOẠI BỎ KHỎI DANH SÁCH VÀ GIẢI PHÓNG BỘ NHỚ
                if (parentPanel != null)
                {
                    parentPanel.Controls.Remove(itemCanXoa); // Loại bỏ khỏi Controls list
                }
                itemCanXoa.Dispose(); // Giải phóng tài nguyên
            }

            // BƯỚC 3: CẬP NHẬT TỔNG TIỀN CUỐI CÙNG
            // Hàm này sẽ lặp qua các item còn lại và tính tổng.
            CapNhatTongTien();
        }

        private void btnLoadLaisp_Click(object sender, EventArgs e)
        {
            Task LoadLaiSP = TaiDanhSachSanPham();
        }
    }
}