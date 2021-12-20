using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUniversity.Application.Contracts.Infrastructure.Repositories;
using eUniversity.Infrastructure.Repositories;
using eUniversity.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using eUniversity.Infrastructure.Services;
using eUniversity.Application.Contracts.Infrastructure.Services;
using System.Reflection;

namespace eUniversity.Infrastructure
{
    public static class InfrastructureInstallation
    {
        public static IServiceCollection AddEUniversityInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddDbContext<EUniversityContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("EUniversityConnectionString")));

            services.AddIdentity<ApplicationUser, IdentityRole<int>>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<EUniversityContext>();

            services.AddScoped<SignInManager<ApplicationUser>>();

            services.AddScoped<IAuthService, AuthService>();
            
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
            services.AddScoped<IGradeRepository, GradeRepository>();
            services.AddScoped<IDegreeRepository, DegreeRepository>();
            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();


            return services;
        }
    }
}
