using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Enrollments
{
    public class EditEnrollmentViewModel
    {
        [Required]
        public int EnrollmentId { get; set; }

        [Required]
        [DisplayName("First name")]
        public string StudentFirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string StudentLastName { get; set; }

        [Required]
        [DisplayName("Username")]
        public string StudentUsername { get; set; }

        [Required]
        [DisplayName("Grade")]
        public int GradeId { get; set; }

        [Required]
        [DisplayName("Course")]
        public string CourseName { get; set; }
    }
}
