namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }

        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [StringLength(100)]
        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Phone Number")]
        public int? Phone { get; set; }

        [StringLength(50)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [StringLength(32)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(50)]
        [DisplayName("Group ID")]
        public string GroupId { get; set; }

        [DisplayName("Activity")]
        public bool Status { get; set; }
    }
}
