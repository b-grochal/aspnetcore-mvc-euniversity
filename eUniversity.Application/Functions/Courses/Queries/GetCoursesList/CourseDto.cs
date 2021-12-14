using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesList
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string SubjectName { get; set; }
        public string SemesterName { get; set; }
        public string DegreeName { get; set; }

    }
}
