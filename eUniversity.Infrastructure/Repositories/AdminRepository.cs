using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using eUniversity.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UserManager<IdentityAdmin> _userManager;

        public AdminRepository(UserManager<IdentityAdmin> userManager)
        {
            _userManager = userManager;
        }

        public Task<Admin> AddAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Admin>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Admin> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
