using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eUniversity.Application;
using eUniversity.Infrastructure;
using Microsoft.AspNetCore.Identity.UI;
using System.Reflection;
using eUniversity.WebUI.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace eUniversity.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddEUniversityApplication();
            services.AddEUniversityInfrastructure(Configuration);
            services.AddControllersWithViews();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Auth/Login";
                options.AccessDeniedPath = "/Auth/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddSession();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("isAdmin",
                        policyBuilder =>
                            policyBuilder.AddRequirements(
                                new IsAdminRequirement()
                            ));

                options.AddPolicy("isStudent",
                        policyBuilder =>
                            policyBuilder.AddRequirements(
                                new IsStudentRequirement()
                            ));

                options.AddPolicy("isTeacher",
                        policyBuilder =>
                            policyBuilder.AddRequirements(
                                new IsTeacherRequirement()
                            ));
            });

            services.AddSingleton<IAuthorizationHandler, IsAdminHandler>();
            services.AddSingleton<IAuthorizationHandler, IsStudentHandler>();
            services.AddSingleton<IAuthorizationHandler, IsTeacherHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
