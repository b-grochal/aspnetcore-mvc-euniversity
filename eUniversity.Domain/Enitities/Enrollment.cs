using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Enrollment : AuditableEntity
    {
        public int EnrollmentID { get; set; }
        public int GradeID { get; set; }
        public Grade Grade { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public string StudentID { get; set; }
        public Student Student { get; set; }
    }
}
