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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly EUniversityContext _eUniversityContext;
        private readonly IMapper _mapper;

        public TeacherRepository(UserManager<ApplicationUser> userManager, EUniversityContext eUniversityContext, IMapper mapper)
        {
            _userManager = userManager;
            _eUniversityContext = eUniversityContext;
            _mapper = mapper;
        }

        public async Task<Teacher> AddAsync(Teacher teacher, string password)
        {
            var applicationUser = _mapper.Map<ApplicationUser>(teacher);
            applicationUser.EmailConfirmed = true;
            applicationUser.PhoneNumberConfirmed = true;
            var identityResult = await _userManager.CreateAsync(applicationUser, password);

            if (identityResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(applicationUser, "Teacher");
                teacher.TeacherId= applicationUser.Id;
                await _eUniversityContext.Teachers.AddAsync(teacher);
                await _eUniversityContext.SaveChangesAsync();
            }
            return teacher;
        }

        public async Task DeleteAsync(Teacher teacher)
        {
            var applicationUser = await _userManager.FindByIdAsync(teacher.TeacherId.ToString());
            var identityResult = await _userManager.DeleteAsync(applicationUser);
            if (identityResult.Succeeded)
            {
                _eUniversityContext.Teachers.Remove(teacher);
            }
            await _eUniversityContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Teacher>> GetAllAsync()
        {
            return await _eUniversityContext.Teachers.ToListAsync();
        }

        public async Task<IReadOnlyList<Teacher>> GetAllAsync(string username)
        {
            return await _eUniversityContext.Teachers
                .Where(a => username == null || a.UserName.Equals(username))
                .ToListAsync();
        }

        public async Task<Teacher> GetByIdAsync(int id)
        {
            return await _eUniversityContext.Teachers.FindAsync(id);
        }

        public async Task UpdateAsync(Teacher teacher)
        {
            var applicationUser = await _userManager.FindByIdAsync(teacher.TeacherId.ToString());
            var updatedApplicationUser = _mapper.Map(teacher, applicationUser);
            var identityResult = await _userManager.UpdateAsync(updatedApplicationUser);
            if (identityResult.Succeeded)
            {
                _eUniversityContext.Teachers.Update(teacher);
            }
            await _eUniversityContext.SaveChangesAsync();
        }
    }
}
