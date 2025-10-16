using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 



namespace QuanLyBanHang.DAL
{
    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int cart_id { get; set; }

        public int user_id { get; set; }

        public int product_id { get; set; }

        public int quantity { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime added_date { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
