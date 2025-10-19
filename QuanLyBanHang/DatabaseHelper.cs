using QuanLyBanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace QuanLyBanHang
{
    public static class DatabaseHelper
    {
        // Chuỗi kết nối chỉ cần viết 1 lần ở đây
        private static string connectionString = @"Data Source=Daz_Vo\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;Connect Timeout=30;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Nếu muốn mở kết nối luôn
        public static SqlConnection OpenConnection()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // Thực thi một câu lệnh SQL trả về đúng 1 giá trị đơn (Đếm số lượng, ...)
        internal static int ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToInt32(result);
                }
            }
        }

        // Thực thi các câu lệnh thao tác dữ liệu (INSERT, UPDATE, DELETE)
        // KHÔNG CẦN TẠO KẾT NỐI, TỰ ĐỘNG CHẠY VÀ ĐÓNG
        //------------------------VD
        //int soDongBiAnhHuong = DatabaseHelper.ExecuteNonQuerySimple("DELETE FROM [QLBH].[dbo].[Cart]");
        //MessageBox.Show($"Đã xóa {soDongBiAnhHuong} mục khỏi giỏ hàng.");
        public static int ThucThiCauLenh(string query)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                // conn.Open() sẽ đảm bảo kết nối được mở
                conn.Open();
                // ExecuteNonQuery() trả về số dòng bị ảnh hưởng
                return cmd.ExecuteNonQuery();
            }
        }


        internal static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery(); // ✅ DÙNG ExecuteNonQuery() — TRẢ VỀ SỐ DÒNG BỊ ẢNH HƯỞNG
            }
        }

        // thực thi câu lệnh sql trả về 1 bảng dữ liệu
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters); // ✅ Thêm tham số vào command

                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            return dt;
        }

        // ép kiểu data thành string
        public static string ExecuteQueryString(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                object result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên

                // Nếu kết quả null hoặc DBNull → trả về chuỗi rỗng
                return result == null || result == DBNull.Value ? "" : result.ToString();
            }
        }



        //lấy thông tại 1 dữ liệu câu tim kiếm
        public static string[] ExecuteQueryFirstRow(string query, SqlParameter[] parameters = null)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var values = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            values[i] = reader.IsDBNull(i) ? "" : reader.GetValue(i).ToString();
                        }
                        return values;
                    }
                }
            }
            return null; // Không có dữ liệu
        }



        // xóa đơn hàng
        public static string XoaDonHang(string id_DH_lay_tu)
        {
            string QueryMDH = $@"
SELECT 
order_id,
order_date,
full_name,
phone_number,
shipping_address,
total_amount,
order_status
FROM Orders 
INNER JOIN Users ON Orders.user_id = Users.user_id
WHERE order_id = '{id_DH_lay_tu}'";

            // xóa đơn hàng
            string deleteQuery = "DELETE FROM Orders WHERE order_id = @order_id"; // xóa sản phẩm
            var deleteParams = new[] { new SqlParameter("@order_id", id_DH_lay_tu) };
            DatabaseHelper.ExecuteQueryFirstRow(deleteQuery, deleteParams);
            MessageBox.Show("Xóa đơn hàng thành công", "DONE",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            return "Đã xóa đơn hàng"; // ✅ Ensure a return value for all code paths
        }

        // thêm sản phẩm vào giỏ hàng



        public static int KiemTraDangNhap()
        {
            if (fLogin.UserId == 0)
            {

                return 0;
            }
            else return 1;
        }

        public class CartItem
        {
            // ID của sản phẩm (Từ bảng Products)
            public int ProductId { get; set; }

            // Số lượng sản phẩm (Tương ứng với numSoLuong)
            public int Quantity { get; set; }

            // Giá bán của từng sản phẩm tại thời điểm đặt hàng
            public decimal PricePerItem { get; set; }

            // Bạn có thể thêm các thông tin khác nếu cần, ví dụ: ProductName
        }
        // Hàm thực thi việc tạo đơn hàng
        //---------------------------------------------------------
        // HÀM 1: LẤY DỮ LIỆU GIỎ HÀNG TỪ SQL (Trả về List<CartItem>)
        //---------------------------------------------------------
        public static async Task<List<CartItem>> LayDuLieuGioHang(string ID_Dang_Nhap)
        {
            List<CartItem> items = new List<CartItem>();

            // Kiểm tra ID người dùng
            if (string.IsNullOrEmpty(ID_Dang_Nhap))
            {
                MessageBox.Show("Lỗi: Không thể xác định ID người dùng khi lấy giỏ hàng.", "Lỗi");
                return items;
            }

            using (SqlConnection ketNoi = new SqlConnection(connectionString))
            {
                string cauTruyVan = @"
                SELECT 
                    c.product_id,
                    c.quantity,
                    p.price -- Giả định cột giá trong bảng Products là 'price'
                FROM [QLBH].[dbo].[Cart] c
                INNER JOIN [QLBH].[dbo].[Products] p ON c.product_id = p.product_id
                WHERE c.user_id = @UserId";

                SqlCommand lenh = new SqlCommand(cauTruyVan, ketNoi);
                lenh.Parameters.AddWithValue("@UserId", ID_Dang_Nhap);

                try
                {
                    await ketNoi.OpenAsync();
                    using (SqlDataReader doc = await lenh.ExecuteReaderAsync())
                    {
                        while (doc.Read())
                        {
                            items.Add(new CartItem
                            {
                                // Đảm bảo kiểu dữ liệu khớp với định nghĩa CartItem
                                ProductId = Convert.ToInt32(doc["product_id"]),
                                Quantity = Convert.ToInt32(doc["quantity"]),
                                PricePerItem = Convert.ToDecimal(doc["price"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy dữ liệu giỏ hàng từ DB: " + ex.Message, "Lỗi SQL");
                }
            }
            return items;
        }

        //---------------------------------------------------------
        // HÀM 2: LẤY ĐỊA CHỈ GIAO HÀNG TỪ SQL (Phụ trợ)
        //---------------------------------------------------------
        public static async Task<string> LayDiaChiNguoiDung(string ID_Dang_Nhap)
        {
            string address = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT address FROM [QLBH].[dbo].[Users] WHERE user_id = @user_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", ID_Dang_Nhap);

                try
                {
                    await conn.OpenAsync();
                    object result = await cmd.ExecuteScalarAsync();
                    if (result != null && result != DBNull.Value)
                    {
                        address = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy địa chỉ người dùng: " + ex.Message, "Lỗi SQL");
                }
            }
            return string.IsNullOrEmpty(address) ? "Địa chỉ mặc định/không xác định" : address;
        }

        //---------------------------------------------------------
        // HÀM 3: TẠO ĐƠN HÀNG MỚI (Thực hiện Transaction)
        //---------------------------------------------------------
        public static async Task<bool> TaoDonHangMoi(string ID_Dang_Nhap, decimal lblTongTien)
        {
            // Lấy danh sách mặt hàng
            List<CartItem> cartItems = await LayDuLieuGioHang(ID_Dang_Nhap);

            if (cartItems == null || cartItems.Count == 0 || lblTongTien <= 0)
            {
                MessageBox.Show("Giỏ hàng trống hoặc tổng tiền không hợp lệ. Không thể tạo đơn hàng.", "Thông báo");
                return false;
            }

            // ==========================================================
            // BƯỚC MỚI: KIỂM TRA TỒN KHO TRƯỚC KHI BẮT ĐẦU TRANSACTION
            // ==========================================================
            bool isStockAvailable = await KiemTraTonKho(ID_Dang_Nhap, cartItems);
            if (!isStockAvailable)
            {
                // Hàm KiemTraTonKho đã hiển thị MessageBox báo lỗi chi tiết
                return false;
            }
            // ==========================================================


            // Lấy địa chỉ giao hàng và chuẩn bị dữ liệu Orders (Không đổi)
            string shippingAddress = await LayDiaChiNguoiDung(ID_Dang_Nhap);
            DateTime orderDate = DateTime.Now;
            string orderStatus = "Đang đóng hàng";

            string insertOrderQuery = @"
        INSERT INTO [QLBH].[dbo].[Orders] 
            (user_id, order_date, total_amount, shipping_address, order_status)
        OUTPUT INSERTED.order_id 
        VALUES (@user_id, @order_date, @total_amount, @shipping_address, @order_status)";

            int new_order_id = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. INSERT Orders và lấy ID 
                    SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, conn, transaction);
                    cmdOrder.Parameters.AddWithValue("@user_id", ID_Dang_Nhap);
                    cmdOrder.Parameters.AddWithValue("@order_date", orderDate);
                    cmdOrder.Parameters.AddWithValue("@total_amount", lblTongTien);
                    cmdOrder.Parameters.AddWithValue("@shipping_address", shippingAddress);
                    cmdOrder.Parameters.AddWithValue("@order_status", orderStatus);

                    new_order_id = (int)await cmdOrder.ExecuteScalarAsync();


                    // 2. INSERT Order_Items VÀ GIẢM SỐ LƯỢNG TỒN KHO
                    string insertItemQuery = "INSERT INTO [QLBH].[dbo].[Order_Items] (order_id, product_id, quantity, price_per_item) VALUES (@order_id, @product_id, @quantity, @price_per_item)";
                    string updateStockQuery = "UPDATE [QLBH].[dbo].[Products] SET stock_quantity = stock_quantity - @quantity WHERE product_id = @product_id";

                    foreach (var item in cartItems)
                    {
                        // Thêm vào Order_Items
                        SqlCommand cmdItem = new SqlCommand(insertItemQuery, conn, transaction);
                        cmdItem.Parameters.AddWithValue("@order_id", new_order_id);
                        cmdItem.Parameters.AddWithValue("@product_id", item.ProductId);
                        cmdItem.Parameters.AddWithValue("@quantity", item.Quantity);
                        cmdItem.Parameters.AddWithValue("@price_per_item", item.PricePerItem);
                        await cmdItem.ExecuteNonQueryAsync();

                        // Giảm số lượng tồn kho
                        SqlCommand cmdUpdateStock = new SqlCommand(updateStockQuery, conn, transaction);
                        cmdUpdateStock.Parameters.AddWithValue("@product_id", item.ProductId);
                        cmdUpdateStock.Parameters.AddWithValue("@quantity", item.Quantity);
                        await cmdUpdateStock.ExecuteNonQueryAsync();
                    }

                    // 3. Xóa giỏ hàng (Không đổi)
                    string deleteCartQuery = "DELETE FROM [QLBH].[dbo].[Cart] WHERE user_id = @user_id";
                    SqlCommand cmdDeleteCart = new SqlCommand(deleteCartQuery, conn, transaction);
                    cmdDeleteCart.Parameters.AddWithValue("@user_id", ID_Dang_Nhap);
                    await cmdDeleteCart.ExecuteNonQueryAsync();

                    // Commit và kết thúc
                    transaction.Commit();
                    MessageBox.Show($"Tạo đơn hàng #{new_order_id} thành công! Địa chỉ: {shippingAddress}", "Thông báo");
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("LỖI khi tạo đơn hàng (Transaction Rollback): " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        // Kiểm tra số lượng tồn kho
        public static async Task<bool> KiemTraTonKho(string ID_Dang_Nhap, List<CartItem> cartItems)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT stock_quantity FROM [QLBH].[dbo].[Products] WHERE product_id = @product_id";
                await conn.OpenAsync();

                foreach (var item in cartItems)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@product_id", item.ProductId);

                    try
                    {
                        // Sử dụng ExecuteScalarAsync để lấy giá trị tồn kho hiện tại
                        object result = await cmd.ExecuteScalarAsync();

                        int currentStock = 0;
                        if (result != null && result != DBNull.Value)
                        {
                            currentStock = Convert.ToInt32(result);
                        }

                        // Kiểm tra: Nếu số lượng đặt lớn hơn số lượng tồn
                        if (item.Quantity > currentStock)
                        {
                            MessageBox.Show($"Lỗi: Sản phẩm ID {item.ProductId} (Số lượng đặt: {item.Quantity}) không đủ hàng! Tồn kho hiện tại: {currentStock}.", "Không đủ Tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false; // Trả về False ngay lập tức
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi kiểm tra tồn kho cho sản phẩm {item.ProductId}: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true; // Tất cả mặt hàng đều đủ tồn kho
        }


        public static class ReportHelper
        {
            public static DataSet ConvertBillToDataSet(QuanLyBanHang.DAL.BillViewModel bill)
            {
                var ds = new DataSet("BillDataSet");

                // Bảng thông tin hóa đơn
                var billTable = new DataTable("BillInfo");
                billTable.Columns.Add("OrderId", typeof(int));
                billTable.Columns.Add("OrderDate", typeof(System.DateTime));
                billTable.Columns.Add("CustomerName", typeof(string));
                billTable.Columns.Add("TotalAmount", typeof(decimal));
                billTable.Rows.Add(bill.OrderId, bill.OrderDate, bill.CustomerName, bill.TotalAmount);
                ds.Tables.Add(billTable);

                // Bảng chi tiết
                var itemsTable = new DataTable("BillItems");
                itemsTable.Columns.Add("ProductName", typeof(string));
                itemsTable.Columns.Add("Quantity", typeof(int));
                itemsTable.Columns.Add("PricePerItem", typeof(decimal));
                itemsTable.Columns.Add("SubTotal", typeof(decimal));

                foreach (var item in bill.Items)
                {
                    itemsTable.Rows.Add(item.ProductName, item.Quantity, item.PricePerItem, item.SubTotal);
                }
                ds.Tables.Add(itemsTable);

                return ds;
            }
        }
        // Đặt hàm này vào class fChiTietSP
        public static void ThemVaoGioHang(int productId, int quantityToAdd)
        {
            // Kiểm tra và chuyển đổi UserID sang kiểu Int (Giả sử UserID trong database là INT)
            if (!int.TryParse(fLogin.UserId.ToString(), out int currentUserId))
            {
                MessageBox.Show("Lỗi định dạng ID người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Câu lệnh SQL: Kiểm tra tồn tại và Cập nhật/Thêm mới
            string query = @"
        IF EXISTS (
            SELECT 1 FROM [QLBH].[dbo].[Cart]
            WHERE [user_id] = @UserID AND [product_id] = @ProductID
        )
        BEGIN
            -- Cập nhật số lượng và ngày thêm
            UPDATE [QLBH].[dbo].[Cart]
            SET [quantity] = [quantity] + @QuantityToAdd,
                [added_date] = GETDATE()
            WHERE [user_id] = @UserID AND [product_id] = @ProductID;
        END
        ELSE
        BEGIN
            -- Thêm mới vào giỏ hàng
            INSERT INTO [QLBH].[dbo].[Cart] (
                [user_id],
                [product_id],
                [quantity],
                [added_date]
            )
            VALUES (
                @UserID,
                @ProductID,
                @QuantityToAdd,
                GETDATE()
            );
        END";

            // 2. Định nghĩa các tham số SQL
            // LƯU Ý: txtSoLuong.Text đã được thay bằng tham số quantityToAdd (int)
            var sqlParams = new[] {
        new SqlParameter("@UserID", currentUserId),
        new SqlParameter("@ProductID", productId),
        new SqlParameter("@QuantityToAdd", quantityToAdd)
    };

            try
            {
                // 3. Thực thi truy vấn
                // DatabaseHelper.ExecuteScalar(query, sqlParams); // Sử dụng ExecuteScalar/ExecuteNonQuery tùy vào helper
                DatabaseHelper.ExecuteNonQuery(query, sqlParams); // Giả định DatabaseHelper có ExecuteNonQuery cho UPDATE/INSERT
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm vào giỏ hàng: {ex.Message}", "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // File: OrderService.cs (hoặc DatabaseHelper.cs)



        // Hàm này chỉ thực hiện logic nghiệp vụ và trả về thông báo lỗi/thành công.
        public static string MuaNgay1SP(int userId, int productId, int quantity)
        {
            if (quantity <= 0)
            {
                return "Vui lòng chọn số lượng lớn hơn 0.";
            }

            using (var QLDB = new QLDB_DB())
            {
                // Bắt đầu Transaction để đảm bảo tính toàn vẹn (ACID)
                using (var transaction = QLDB.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. LẤY VÀ KIỂM TRA DỮ LIỆU
                        var user = QLDB.Users.FirstOrDefault(u => u.user_id == userId);
                        var product = QLDB.Products.FirstOrDefault(p => p.product_id == productId);

                        if (user == null)
                            return "Lỗi: Không tìm thấy thông tin người dùng.";
                        if (product == null)
                            return "Lỗi: Sản phẩm không tồn tại.";
                        if (product.stock_quantity < quantity)
                            return "Lỗi: Số lượng tồn kho không đủ.";

                        // 2. TÍNH TOÁN VÀ XỬ LÝ
                        decimal DonGia = product.price;
                        decimal TongTien = quantity * DonGia;
                        int SoLuongConLai = product.stock_quantity - quantity;
                        DateTime NgayMua = DateTime.Now;

                        // FIX NULL/EMPTY: Đảm bảo giá trị bắt buộc không rỗng
                        string DiaChiGiaoHang = string.IsNullOrWhiteSpace(user.address) ? "Địa chỉ chưa cập nhật" : user.address;
                        string TrangThaiDonHang = "Đã xác nhận đơn hàng";

                        // 3. TẠO VÀ LƯU ORDER (Lưu lần 1: Lấy Order.order_id)
                        var Order = new Order
                        {
                            user_id = userId,
                            order_date = NgayMua,
                            total_amount = TongTien,
                            shipping_address = DiaChiGiaoHang,
                            order_status = TrangThaiDonHang
                        };
                        QLDB.Orders.Add(Order);
                        QLDB.SaveChanges();

                        // 4. TẠO VÀ LƯU ORDER_ITEMS
                        var Order_Items = new Order_Items
                        {
                            order_id = Order.order_id,
                            product_id = productId,
                            quantity = quantity,
                            price_per_item = DonGia
                        };
                        QLDB.Order_Items.Add(Order_Items);

                        // 5. CẬP NHẬT TỒN KHO
                        product.stock_quantity = SoLuongConLai;

                        // 6. LƯU CÁC THAY ĐỔI CÒN LẠI VÀ COMMIT
                        QLDB.SaveChanges();
                        transaction.Commit();

                        return "Đặt hàng thành công!"; // Trả về thông báo thành công

                    }
                    catch (DbEntityValidationException ex)
                    {
                        transaction.Rollback();
                        var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => $"{x.PropertyName}: {x.ErrorMessage}");
                        return "Lỗi xác thực dữ liệu:\n" + string.Join("\n", errorMessages);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return $"Đã xảy ra lỗi trong quá trình đặt hàng: {ex.Message}";
                    }
                }
            }
        }
    






   
    }
}




