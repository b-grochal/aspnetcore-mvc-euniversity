using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Courses
{
    public class EnrollOnCourseViewModel
    {
        [Required]
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
