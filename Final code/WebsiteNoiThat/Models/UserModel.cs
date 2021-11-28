using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteNoiThat.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("ID")]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public int? Phone { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(32)]
        [DisplayName("Passwordd")]
        public string Password { get; set; }
      
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "The email address is not valid")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Group user")]
        public string GroupId { get; set; }

        [Required]
        [DisplayName("Activity")]
        public bool Status { get; set; }
      
        
    }
}