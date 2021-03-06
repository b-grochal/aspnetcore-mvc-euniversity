using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Auth
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }
    }
}
