using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Admins
{
    public class AdminDetailsViewModel
    {
        [DisplayName("Identifier")]
        public int AdminId { get; set; }

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
