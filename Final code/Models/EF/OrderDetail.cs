namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [DisplayName("Invoice detail ID")]
        public int OrderDetailId { get; set; }
        [DisplayName("Invoice ID")]
        public int? OrderId { get; set; }
        [DisplayName("Product ID")]
        public int? ProductId { get; set; }
        [DisplayName("Price")]
        public int? Price { get; set; }
        [DisplayName("Quantity")]
        public int? Quantity { get; set; }
    }
}
