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
        public Subject Subject { get; set; }
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }
        public int DegreeId { get; set; }
        public Degree Degree { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
