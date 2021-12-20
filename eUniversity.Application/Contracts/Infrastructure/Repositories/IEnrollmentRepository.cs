using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Contracts.Infrastructure.Repositories
{
    public interface IEnrollmentRepository : IAsyncRepository<Enrollment>
    {
        Task<IReadOnlyList<Enrollment>> GetAllAsync(int studentId);
    }
}
