using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Entities
{
    public class IdentityStudent : ApplicationUser
    {
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
