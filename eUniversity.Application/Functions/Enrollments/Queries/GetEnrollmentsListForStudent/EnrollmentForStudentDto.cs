using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Enrollments.Queries.GetEnrollmentsListForStudent
{
    public class EnrollmentForStudentDto
    {
        public int EnrollmentId { get; set; }
        public string CourseName { get; set; }
        public string SemesterName { get; set; }
        public string SubjectName { get; set; }
        public string DegreeName { get; set; }
        public string GradeName { get; set; }
    }
}
