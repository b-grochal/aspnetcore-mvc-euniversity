﻿using eUniversity.Domain.Common;
using eUniversity.Domain.Enitities;
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

        public EUniversityContext(DbContextOptions<EUniversityContext> options) : base(options)
        {

        }

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
            //modelBuilder.
            //    ApplyConfigurationsFromAssembly
            //    (typeof(EduZbieraczContext).Assembly);

            modelBuilder.Entity<IdentityAdmin>().ToTable("Admins");
            modelBuilder.Entity<IdentityAdmin>().ToTable("Students");
            modelBuilder.Entity<IdentityAdmin>().ToTable("Teachers");

            //foreach (var item in DummyCategories.Get())
            //{
            //    modelBuilder.Entity<Category>().HasData(item);
            //}

            //foreach (var item in DummyPosts.Get())
            //{
            //    modelBuilder.Entity<Post>(b =>
            //    {
            //        b.HasData(item);
            //        //b.OwnsOne(e => e.Category).HasData(item.Category);
            //    });

            //    //modelBuilder.Entity<Post>().HasData(item);
            //    //modelBuilder.owns
            //}

            //foreach (var item in DummyWebinars.Get())
            //{
            //    modelBuilder.Entity<Webinar>().HasData(item);
            //}
        }
    }
}
