using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyRoles
    {
        public static List<IdentityRole<int>> Get()
        {
            return new List<IdentityRole<int>>
            {
                new IdentityRole<int>
                {
                    Id=DummySeed.AdminRole,
                    Name="Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole<int>
                {
                    Id=DummySeed.TeacherRole,
                    Name="Teacher",
                    NormalizedName = "TEACHER"
                },
                new IdentityRole<int>
                {
                    Id=DummySeed.Student,
                    Name="Student",
                    NormalizedName = "STUDENT"
                },
            };
        }
    }
}
