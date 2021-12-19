using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Contracts.Infrastructure.Repositories
{
    public interface ITeacherRepository
    {
        Task<Teacher> GetByIdAsync(int id);

        Task<IReadOnlyList<Teacher>> GetAllAsync();

        Task<Teacher> AddAsync(Teacher teacher, string password);

        Task UpdateAsync(Teacher teacher);

        Task DeleteAsync(Teacher teacher);

        Task<IReadOnlyList<Teacher>> GetAllAsync(string username);
    }
}
