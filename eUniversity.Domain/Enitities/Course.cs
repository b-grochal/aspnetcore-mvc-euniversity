using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Course : AuditableEntity
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
        public int SemesterID { get; set; }
        public Semester Semester { get; set; }
        public int DegreeID { get; set; }
        public Degree Degree { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
