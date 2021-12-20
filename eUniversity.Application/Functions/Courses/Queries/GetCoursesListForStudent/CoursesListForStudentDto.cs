using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesListForStudent
{
    public class CoursesListForStudentDto
    {
        public List<CourseForStudentDto> Courses { get; set; }
        public string SearchedName { get; set; }
    }
}
