using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyBanHang.DAL
{
    public class ListAnhSP
    {
        // ĐỊNH NGHĨA KHÓA CHÍNH Ở ĐÂY
        [Key]
        public int image_id { get; set; }

        public int product_id { get; set; }
        public string image_url { get; set; }

        public virtual Product Product { get; set; }
    }
}