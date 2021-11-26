using eUniversity.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyTeachers
    {
        public static List<IdentityTeacher> Get()
        {
            return new List<IdentityTeacher>
            {
                new IdentityTeacher
                {
                    Id = DummySeed.Teacher,
                    FirstName = "Michael",
                    LastName = "Scott",
                    UserName = "michsco123",
                    NormalizedUserName = "MICHSCO123",
                    Email = "michsco123@euniversity.com",
                    NormalizedEmail = "MICHSCO123@EUNIVERSITY.COM",
                    EmailConfirmed = true,
                    PhoneNumber = "123-456-789",
                    PhoneNumberConfirmed = true
                }
            };
        }
    }
}
