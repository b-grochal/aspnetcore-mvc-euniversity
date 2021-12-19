using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Contracts.Infrastructure.Repositories
{
    public interface ICourseRepository : IAsyncRepository<Course>
    {
        Task<IReadOnlyList<Course>> GetAllAsync(string name);
    }
}
