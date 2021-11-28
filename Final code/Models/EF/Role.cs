namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role
    {
        [StringLength(50)]
        [Display(Name = "Role ID")]
        public string RoleId { get; set; }

        [StringLength(50)]
        [Display(Name = "Description")]
        public string Name { get; set; }
    }
}
