namespace QuanLyBanHang.DAL
{
    using QuanLyBanHang.DAL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Carts = new HashSet<Cart>();
            Order_Items = new HashSet<Order_Items>();
        }

        [Key]
        public int product_id { get; set; }

        [Required]
        [StringLength(255)]
        public string product_name { get; set; }

        [Required]
        public string description { get; set; }

        public decimal price { get; set; }

        public int stock_quantity { get; set; }

        public string category_id { get; set; }

        [Required]
        [StringLength(500)]
        public string image_url { get; set; }

        [StringLength(50)]
        public string barcode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }
        public virtual ICollection<ListAnhSP> ListAnhSPs { get; set; }
    }
}
