using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Degree : AuditableEntity
    {
        public int DegreeID { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
