using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Contracts.Infrastructure.Repositories
{
    public interface IAdminRepository
    {
        Task<Admin> GetByIdAsync(int id);

        Task<IReadOnlyList<Admin>> GetAllAsync();

        Task<Admin> AddAsync(Admin admin, string password);

        Task UpdateAsync(Admin admin);

        Task DeleteAsync(Admin admin);

        Task<IReadOnlyList<Admin>> GetAllAsync(string username);
    }
}
