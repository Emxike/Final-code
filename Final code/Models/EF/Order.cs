namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DisplayName("Invoice ID")]
        public int OrderId { get; set; }

        [StringLength(50)]
        [DisplayName("Full Name")]
        public string ShipName { get; set; }

        [DisplayName("User ID")]
        public int? UserId { get; set; }

        [DisplayName("Recipient's phone number")]
        public int? ShipPhone { get; set; }

        [DisplayName("Recipient's email")]
        public string ShipEmail { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Update date")]
        public DateTime? UpdateDate { get; set; }

        [DisplayName("Delivery Address")]
        public string ShipAddress { get; set; }

        [DisplayName("Activity")]
        public int StatusId { get; set; }
    }
}
