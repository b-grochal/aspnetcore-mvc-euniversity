using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyUserRoles
    {
        public static List<IdentityUserRole<int>> Get()
        {
            return new List<IdentityUserRole<int>>
            {
                new IdentityUserRole<int>
                {
                    RoleId = DummySeed.AdminRole,
                    UserId = DummySeed.Admin
                },
                new IdentityUserRole<int>
                {
                    RoleId = DummySeed.TeacherRole,
                    UserId = DummySeed.Teacher
                },
                new IdentityUserRole<int>
                {
                    RoleId = DummySeed.StudentRole,
                    UserId = DummySeed.Student
                }
            };
        }
    }
}
