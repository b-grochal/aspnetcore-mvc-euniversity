using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Course : AuditableEntity
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }
        public int DegreeId { get; set; }
        public virtual Degree Degree { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
