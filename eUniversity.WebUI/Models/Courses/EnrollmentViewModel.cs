using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Courses
{
    public class EnrollmentViewModel
    {
        [DisplayName("Name")]
        public string StudentFullName { get; set; }
        
        [DisplayName("Username")]
        public string StudentUsername { get; set; }
        
        [DisplayName("Grade")]
        public string GradeName { get; set; }
    }
}
