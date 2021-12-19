using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(EUniversityContext eUniversityContext) : base(eUniversityContext) { }

        public async Task<IReadOnlyList<Course>> GetAllAsync(string name)
        {
            return await _dbContext.Courses
                .Where(a => name == null || a.Name.Contains(name))
                .Include(c => c.Semester)
                .Include(c => c.Subject)
                .Include(c => c.Degree)
                .ToListAsync();
        }
    }
}
