using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Students
{
    public class StudentDetailsViewModel
    {
        [DisplayName("Identifier")]
        public int StudentId { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("User name")]
        public string UserName { get; set; }

        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
    }
}
