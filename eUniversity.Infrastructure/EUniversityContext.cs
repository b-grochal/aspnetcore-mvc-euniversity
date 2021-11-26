using eUniversity.Domain.Common;
using eUniversity.Domain.Enitities;
using eUniversity.Infrastructure.DummyData;
using eUniversity.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure
{
    public class EUniversityContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public DbSet<IdentityAdmin> Admins { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<IdentityStudent> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<IdentityTeacher> Teachers { get; set; }

        public EUniversityContext(DbContextOptions<EUniversityContext> options) : base(options) { }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUsers");
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("ApplicationUserLogins");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("ApplicationUserTokens");
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("ApplicationUserClaims");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("ApplicationUserRoles");
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityRole<int>>().ToTable("Roles");

            modelBuilder.Entity<IdentityAdmin>().ToTable("Admins");
            modelBuilder.Entity<IdentityStudent>().ToTable("Students");
            modelBuilder.Entity<IdentityTeacher>().ToTable("Teachers");

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            foreach(var role in DummyRoles.Get())
            {
                modelBuilder.Entity<IdentityRole<int>>().HasData(role);
            }

            foreach(var teacher in DummyTeachers.Get())
            {
                teacher.PasswordHash = passwordHasher.HashPassword(teacher, "P@ssw0rd");
                teacher.SecurityStamp = Guid.NewGuid().ToString();
                modelBuilder.Entity<IdentityTeacher>().HasData(teacher);
            }

            foreach(var userRole in DummyUserRoles.Get())
            {
                modelBuilder.Entity<IdentityUserRole<int>>().HasData(userRole);
            }

            foreach(var subject in DummySubjects.Get())
            {
                modelBuilder.Entity<Subject>().HasData(subject);
            }

            foreach (var grade in DummyGrades.Get())
            {
                modelBuilder.Entity<Grade>().HasData(grade);
            }

            foreach (var semester in DummySemesters.Get())
            {
                modelBuilder.Entity<Semester>().HasData(semester);
            }

            foreach (var degree in DummyDegrees.Get())
            {
                modelBuilder.Entity<Degree>().HasData(degree);
            }

            foreach(var course in DummyCourses.Get())
            {
                course.PasswordHash = BCrypt.Net.BCrypt.HashPassword("P@ssw0rd");
                modelBuilder.Entity<Course>().HasData(course);
            }

            foreach(var enrollment in DummyEnrollments.Get())
            {
                modelBuilder.Entity<Enrollment>().HasData(enrollment);
            }   
        }
    }
}
