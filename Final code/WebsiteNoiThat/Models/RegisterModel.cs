using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteNoiThat.Models
{
    public class RegisterModel
    {
       

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username required")]

        public string UserName { set; get; }

        [Display(Name = "Password")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Password length is at least 4 characters.")]
        [Required(ErrorMessage = "Password required")]
        public string Password { set; get; }

        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password was wrong.")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter your first and last name")]
        public string Name { set; get; }

        [Display(Name = "Address")]
        public string Address { set; get; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email required")]

        [EmailAddress(ErrorMessage = "The email address is not valid")]
        public string Email { set; get; }

        [Display(Name = "Phone Number")]
        public int Phone { set; get; }

        public int CartId { get; set; }
    }
}