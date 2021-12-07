using AutoMapper;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Domain.Enitities;
using eUniversity.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly EUniversityContext _eUniversityContext;
        private readonly IMapper _mapper;

        public AdminRepository(UserManager<ApplicationUser> userManager, EUniversityContext eUniversityContext, IMapper mapper)
        {
            _userManager = userManager;
            _eUniversityContext = eUniversityContext;
            _mapper = mapper;
        }

        public async Task<Admin> AddAsync(Admin entity, string password)
        {
            var applicationUser = _mapper.Map<ApplicationUser>(entity);
            applicationUser.EmailConfirmed = true;
            applicationUser.PhoneNumberConfirmed = true;
            var identityResult = await _userManager.CreateAsync(applicationUser, password);
            
            if(identityResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(applicationUser, "Admin");
                entity.AdminId = applicationUser.Id;
                await _eUniversityContext.Admins.AddAsync(entity);
                await _eUniversityContext.SaveChangesAsync();
            }
            return entity;
        }

        public async Task DeleteAsync(Admin entity)
        {
            var applicationUser = await _userManager.FindByIdAsync(entity.AdminId.ToString());
            var identityResult = await _userManager.DeleteAsync(applicationUser);
            if(identityResult.Succeeded)
            {
                _eUniversityContext.Admins.Remove(entity);
            }
            await _eUniversityContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Admin>> GetAllAsync()
        {
            return await _eUniversityContext.Admins.ToListAsync();
        }

        public async Task<IReadOnlyList<Admin>> GetAllAsync(string username)
        {
            return await _eUniversityContext.Admins
                .Where(a => username == null || a.UserName.Equals(username))
                .ToListAsync();
        }

        public async Task<Admin> GetByIdAsync(int id)
        {
            return await _eUniversityContext.Admins.FindAsync(id);
        }

        public async Task UpdateAsync(Admin entity)
        {
            var applicationUser = await _userManager.FindByIdAsync(entity.AdminId.ToString());
            var updatedApplicationUser = _mapper.Map(entity, applicationUser);
            var identityResult = await _userManager.UpdateAsync(updatedApplicationUser);
            if(identityResult.Succeeded)
            {
                _eUniversityContext.Admins.Update(entity);
            }
            await _eUniversityContext.SaveChangesAsync();
        }
    }
}
