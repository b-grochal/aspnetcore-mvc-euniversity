using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentDetails
{
    class EnrollmentDetailsDto
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentUsername{ get; set; }
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
