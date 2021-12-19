using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Students
{
    public class EditStudentViewModel
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
    }
}
