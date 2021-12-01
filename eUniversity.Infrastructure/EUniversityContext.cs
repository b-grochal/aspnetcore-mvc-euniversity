using eUniversity.Domain.Common;
using eUniversity.Domain.Enitities;
using eUniversity.Infrastructure.DummyData;
using eUniversity.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure
{
    public class EUniversityContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

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

            modelBuilder.Entity<Admin>().Property(a => a.AdminId).ValueGeneratedNever();
            modelBuilder.Entity<Student>().Property(s => s.StudentId).ValueGeneratedNever();
            modelBuilder.Entity<Teacher>().Property(t => t.TeacherId).ValueGeneratedNever();

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            foreach(var role in DummyRoles.Get())
            {
                modelBuilder.Entity<IdentityRole<int>>().HasData(role);
            }

            foreach(var applicationUser in DummyApplicationUsers.Get())
            {
                applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "P@ssw0rd");
                applicationUser.SecurityStamp = Guid.NewGuid().ToString();
                modelBuilder.Entity<ApplicationUser>().HasData(applicationUser);
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

            foreach (var admin in DummyAdmins.Get())
            {
                modelBuilder.Entity<Admin>().HasData(admin);
            }

            foreach (var teacher in DummyTeachers.Get())
            {
                modelBuilder.Entity<Teacher>().HasData(teacher);
            }

            foreach (var student in DummyStudents.Get())
            {
                modelBuilder.Entity<Student>().HasData(student);
            }

            foreach (var course in DummyCourses.Get())
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
