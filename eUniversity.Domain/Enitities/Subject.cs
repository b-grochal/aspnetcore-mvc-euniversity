using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Subject : AuditableEntity
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
