using eUniversity.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyStudents
    {
        public static List<IdentityStudent> Get()
        {
            return new List<IdentityStudent>
            {
                new IdentityStudent
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
