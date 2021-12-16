using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Repositories
{
    public class DegreeRepository : BaseRepository<Degree>, IDegreeRepository
    {
        public DegreeRepository(EUniversityContext eUniversityContext) : base(eUniversityContext) { }
    }
}
