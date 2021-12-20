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
    public class EnrollmentRepository : BaseRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(EUniversityContext eUniversityContext) : base(eUniversityContext) { }

        public async Task<IReadOnlyList<Enrollment>> GetAllAsync(int studentId)
        {
            return await _dbContext.Enrollments
                .Where(e =>  e.StudentId == studentId)
                .ToListAsync();
        }
    }
}
