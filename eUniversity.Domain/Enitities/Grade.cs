using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Grade : AuditableEntity
    {
        public int GradeID { get; set; }
        public string Name { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
