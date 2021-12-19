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
        public virtual Grade Grade { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
