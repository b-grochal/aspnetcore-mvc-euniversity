using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity.WebUI.Models.Courses
{
    public class CourseForStudentViewModel
    {
        [DisplayName("Identifier")]
        public int CourseId { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Subject")]
        public string SubjectName { get; set; }

        [DisplayName("Semester")]
        public string SemesterName { get; set; }

        [DisplayName("Degree")]
        public string DegreeName { get; set; }
        public bool IsEnrolled { get; set; }
    }
}
