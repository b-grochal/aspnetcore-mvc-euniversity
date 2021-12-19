using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesList
{
    public class CoursesListDto
    {
        public List<CourseDto> Courses { get; set; }
        public string SearchedName { get; set; }
    }
}
