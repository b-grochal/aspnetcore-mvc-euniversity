using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCourseDetails
{
    public class CourseDetailsDto
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int SemesterId { get; set; }
        public int DegreeId { get; set; }
        public string SubjectName { get; set; }
        public string SemesterName { get; set; }
        public string DegreeName { get; set; }
        public List<EnrollmentDto> Enrollments { get; set; }
    }
}
