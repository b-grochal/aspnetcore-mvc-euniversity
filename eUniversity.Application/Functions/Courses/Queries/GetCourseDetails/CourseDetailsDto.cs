using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCourseDetails
{
    public class CourseDetailsDto
    {
        public string Name { get; set; }
        public string SubjectName { get; set; }
        public string SemesterName { get; set; }
        public string DegreeName { get; set; }
        public List<EnrollmentDto> Enrollments { get; set; }
    }
}
