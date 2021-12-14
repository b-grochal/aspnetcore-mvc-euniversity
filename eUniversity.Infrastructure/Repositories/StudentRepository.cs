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
    public class StudentRepository : IStudentRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly EUniversityContext _eUniversityContext;
        private readonly IMapper _mapper;

        public StudentRepository(UserManager<ApplicationUser> userManager, EUniversityContext eUniversityContext, IMapper mapper)
        {
            _userManager = userManager;
            _eUniversityContext = eUniversityContext;
            _mapper = mapper;
        }

        public async Task<Student> AddAsync(Student student, string password)
        {
            var applicationUser = _mapper.Map<ApplicationUser>(student);
            applicationUser.EmailConfirmed = true;
            applicationUser.PhoneNumberConfirmed = true;
            var identityResult = await _userManager.CreateAsync(applicationUser, password);

            if (identityResult.Succeeded)
            {
                await _userManager.AddToRoleAsync(applicationUser, "Student");
                student.StudentId = applicationUser.Id;
                await _eUniversityContext.Students.AddAsync(student);
                await _eUniversityContext.SaveChangesAsync();
            }
            return student;
        }

        public async Task DeleteAsync(Student student)
        {
            var applicationUser = await _userManager.FindByIdAsync(student.StudentId.ToString());
            var identityResult = await _userManager.DeleteAsync(applicationUser);
            if (identityResult.Succeeded)
            {
                _eUniversityContext.Students.Remove(student);
            }
            await _eUniversityContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Student>> GetAllAsync()
        {
            return await _eUniversityContext.Students.ToListAsync();
        }

        public async Task<IReadOnlyList<Student>> GetAllAsync(string username)
        {
            return await _eUniversityContext.Students
                .Where(a => username == null || a.UserName.Equals(username))
                .ToListAsync();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _eUniversityContext.Students.FindAsync(id);
        }

        public async Task UpdateAsync(Student student)
        {
            var applicationUser = await _userManager.FindByIdAsync(student.StudentId.ToString());
            var updatedApplicationUser = _mapper.Map(student, applicationUser);
            var identityResult = await _userManager.UpdateAsync(updatedApplicationUser);
            if (identityResult.Succeeded)
            {
                _eUniversityContext.Students.Update(student);
            }
            await _eUniversityContext.SaveChangesAsync();
        }
    }
}
