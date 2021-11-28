namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("ID Product")]
        public int ProductId { get; set; }

        [StringLength(50)]
        [DisplayName("Name Product")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Price")]
        public int? Price { get; set; }

        [DisplayName("Quantity")]
        public int? Quantity { get; set; }

        [DisplayName("Provider")]
        public int? ProviderId { get; set; }

        [DisplayName("Product catalog ID")]
        public int? CateId { get; set; }

        [DisplayName("Photo Product")]
        public string Photo { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Promotion start date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Promotion end date")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Sale Off (%)")]
        public int? Discount { get; set; }
    }
}
