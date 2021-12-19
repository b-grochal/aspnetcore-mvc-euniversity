using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Semester : AuditableEntity
    {
        public int SemesterId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Semester> Semesters { get; set; }
    }
}
