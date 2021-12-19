using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCourseDetails
{
    public class EnrollmentDto
    {
        public int EnrollmentId { get; set; }
        public string StudentFullName { get; set; }
        public string StudentUsername { get; set; }
        public string GradeName { get; set; }
    }
}
