using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Enrollments
{
    public class EnrollmentDetailsViewModel
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentUsername { get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
