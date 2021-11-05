using eUniversity.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Domain.Enitities
{
    public class Semester : AuditableEntity
    {
        public int SemesterID { get; set; }
        public string Name { get; set; }
        public ICollection<Semester> Semesters { get; set; }
    }
}
