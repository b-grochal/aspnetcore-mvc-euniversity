using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Enrollments
{
    public class EnrollmentForStudentViewModel
    {
        [DisplayName("Identifier")]
        public int EnrollmentId { get; set; }

        [DisplayName("Course")]
        public string CourseName { get; set; }

        [DisplayName("Semster")]
        public string SemesterName { get; set; }

        [DisplayName("Subject")]
        public string SubjectName { get; set; }

        [DisplayName("Degree")]
        public string DegreeName { get; set; }

        [DisplayName("Grade")]
        public string GradeName { get; set; }
    }
}
