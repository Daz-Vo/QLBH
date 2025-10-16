namespace QuanLyBanHang.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Order_Items = new HashSet<Order_Items>();
        }

        [Key]
        public int order_id { get; set; }

        public int user_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime order_date { get; set; }

        public decimal total_amount { get; set; }

        [Required]
        public string shipping_address { get; set; }

        [Required]
        [StringLength(50)]
        public string order_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }

        public virtual User User { get; set; }
    }
}
