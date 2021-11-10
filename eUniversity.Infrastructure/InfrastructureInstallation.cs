﻿using Microsoft.EntityFrameworkCore;
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

namespace eUniversity.Infrastructure
{
    public static class InfrastructureInstallation
    {
        public static IServiceCollection AddEUniversityInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EUniversityContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("EUniversityConnectionString")));

            services.AddIdentity<ApplicationUser, IdentityRole<int>>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<EUniversityContext>();

            services.AddScoped<IAdminRepository, AdminRepository>();

            return services;
        }
    }
}
