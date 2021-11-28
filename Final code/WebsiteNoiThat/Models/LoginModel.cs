using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteNoiThat.Models
{
    public class LoginModel
    {
       
        [DisplayName("Username")]
        [Required(ErrorMessage = "You must enter an username!")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "You must enter an password!")]
        public string Password { get; set; }
    }
}