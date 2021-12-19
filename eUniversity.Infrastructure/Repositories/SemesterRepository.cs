using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Repositories
{
    class SemesterRepository : BaseRepository<Semester>, ISemesterRepository
    {
        public SemesterRepository(EUniversityContext eUniversityContext) : base(eUniversityContext) { }
    }
}
