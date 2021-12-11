using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Contracts.Infrastructure.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> GetByIdAsync(int id);

        Task<IReadOnlyList<Student>> GetAllAsync();

        Task<Student> AddAsync(Student student, string password);

        Task UpdateAsync(Student student);

        Task DeleteAsync(Student student);

        Task<IReadOnlyList<Student>> GetAllAsync(string username);
    }
}
