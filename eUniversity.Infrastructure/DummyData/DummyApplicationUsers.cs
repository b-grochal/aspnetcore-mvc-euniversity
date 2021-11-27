using eUniversity.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyApplicationUsers
    {
        public static List<ApplicationUser> Get()
        {
            return new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id = DummySeed.Admin,
                    FirstName = "David",
                    LastName = "Wallace",
                    UserName = "daviwal123",
                    NormalizedUserName = "DAVIWAL123",
                    Email = "daviwal123@euniversity.com",
                    NormalizedEmail = "DAVIWAL123@EUNIVERSITY.COM",
                    EmailConfirmed = true,
                    PhoneNumber = "123-456-789",
                    PhoneNumberConfirmed = true
                },
                new ApplicationUser
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
                },
                new ApplicationUser
                {
                    Id = DummySeed.Student,
                    FirstName = "Dwight",
                    LastName = "Schrute",
                    UserName = "dwigsch123",
                    NormalizedUserName = "DWIGSCH123",
                    Email = "dwigsch123@euniversity.com",
                    NormalizedEmail = "DWIGSCH123@EUNIVERSITY.COM",
                    EmailConfirmed = true,
                    PhoneNumber = "123-456-789",
                    PhoneNumberConfirmed = true
                }
            };
        }
    }
}
