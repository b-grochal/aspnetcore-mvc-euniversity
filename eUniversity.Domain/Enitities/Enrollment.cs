using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Enrollment : AuditableEntity
    {
        public int EnrollmentId { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
    }
}
