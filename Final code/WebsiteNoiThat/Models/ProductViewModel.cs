using Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteNoiThat.Models
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(50)]
        [Required]
        [DisplayName("Name Product")]
        public string Name { get; set; }

        [DisplayName("Product Description")]
        public string Description { get; set; }

        [DisplayName("Unit Price")]
        [Required]
        public int? Price { get; set; }

        [Required]
        [DisplayName("Quantity")]
        public int? Quantity { get; set; }

        [DisplayName("Supplier")]
        public int? ProviderId { get; set; }

        [DisplayName("Product portfolio")]
        public int? CateId { get; set; }

        [DisplayName("Product portfolio")]
        public string CateName { get; set; }

        [DisplayName("Supplier")]
        public string ProviderName { get; set; }

        [DisplayName("Pricture")]
        [Required]
        public string Photo { get; set; }

        [DisplayName("Promotion start date")]
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [DisplayName("Promotion end date")]
        [Column(TypeName = "date")]
        //[DateGreaterThanAttribute(otherPropertyName = "StartDate", ErrorMessage = "Ngày kết thúc phải muộn hơn ngày bắt đầu")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Sale off (%)")]
        public int? Discount { get; set; }
    }
}