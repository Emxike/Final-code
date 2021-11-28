using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteNoiThat.Areas.Admin.Models
{
    public class OrderView
    {
        [DisplayName("Invoid ID")]
        public int OrderId { get; set; }

        [DisplayName("User ID")]
        public int? UserId { get; set; }

        [StringLength(50)]
        [DisplayName("Name User")]
        public string ShipName { get; set; }

        [DisplayName("Phone Number")]
        public int? ShipPhone { get; set; }

        [DisplayName("Delivery Address")]
        public string ShipAddress { get; set; }

        [DisplayName("Recipient's Email")]
        public string ShipEmail { get; set; }
        
        //[DisplayName("Tổng tiền")]
        //public string Total { get; set; }
        
        [DisplayName("Status Product")]
        public string StatusName { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "date")]
        [DisplayName("Update Date")]
        public DateTime? UpdateDate { get; set; }
    }
}