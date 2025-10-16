using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyBanHang.DAL;


namespace QuanLyBanHang.Services
{
    public class BillService
    {
        private readonly QLDB_DB _context; 
        public BillService(QLDB_DB context)
        {
            _context = context;
        }

        public BillViewModel GetBillByOrderId(int orderId)
        {
            var order = _context.Orders
                .Where(o => o.order_id == orderId)
                .FirstOrDefault();

            if (order == null)
                throw new ArgumentException($"Không tìm thấy đơn hàng với mã {orderId}");

            // Lấy thông tin khách hàng
            var customer = _context.Users
                .Where(u => u.user_id == order.user_id)
                .Select(u => u.full_name)
                .FirstOrDefault();

            // Lấy danh sách chi tiết đơn hàng
            var orderItems = _context.Order_Items
                .Where(oi => oi.order_id == orderId)
                .Join(_context.Products,
                    oi => oi.product_id,
                    p => p.product_id,
                    (oi, p) => new BillItemView
                    {
                        ProductName = p.product_name,
                        Quantity = oi.quantity,
                        PricePerItem = oi.price_per_item,
                        SubTotal = oi.quantity * oi.price_per_item
                    })
                .ToList();

            // Tạo BillViewModel
            var bill = new BillViewModel
            {
                OrderId = order.order_id,
                OrderDate = order.order_date,
                CustomerName = customer ?? "Khách hàng không xác định",
                TotalAmount = order.total_amount,
                Items = orderItems
            };

            return bill;
        }
    }
}