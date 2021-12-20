using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using eUniversity.Infrastructure.DummyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Repositories
{
    public class GradeRepository : BaseRepository<Grade>, IGradeRepository
    {
        public GradeRepository(EUniversityContext eUniversityContext) : base(eUniversityContext) { }

        public async Task<Grade> GetDefaultGrade()
        {
            return await _dbContext.Grades.FindAsync(DummySeed.NoGrade);
        }
    }
}
