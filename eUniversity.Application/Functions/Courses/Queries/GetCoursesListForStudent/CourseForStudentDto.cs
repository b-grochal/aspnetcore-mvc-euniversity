using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesListForStudent
{
    public class CourseForStudentDto
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string SubjectName { get; set; }
        public string SemesterName { get; set; }
        public string DegreeName { get; set; }
        public bool IsEnrolled { get; set; }
    }
}
