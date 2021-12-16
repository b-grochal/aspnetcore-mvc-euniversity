using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Students
{
    public class StudentViewModel
    {
        [DisplayName("Identifier")]
        public int StudentId { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("User name")]
        public string UserName { get; set; }
    }
}
