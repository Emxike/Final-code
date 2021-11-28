using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteNoiThat.Areas.Admin.Models
{
    public class OrderProduct
    {
        //[DisplayName("Mã sản phẩm")]
        //public int? ProductId { get; set; }

        //[DisplayName("Tên sản phẩm")]
        //public string Name { get; set; }

        //[DisplayName("Số lượng")]
        //public int? Quantity { get; set; }

        //[DisplayName("Đơn giá")]
        //public int? Price { get; set; }

        [DisplayName("Invoice ID")]
        public int? OrderId { get; set; }

        [DisplayName("Product ID")]
        public int ProductId { get; set; }

        [DisplayName("Product Name ")]
        public string ProductName { get; set; }
        [DisplayName("Price")]
        public int? Price { get; set; }
        [DisplayName("Quantity")]
        public int? Quantity { get; set; }

    }

}
