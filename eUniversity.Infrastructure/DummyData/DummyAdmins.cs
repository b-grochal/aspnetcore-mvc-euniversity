using eUniversity.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyAdmins
    {
        public static List<IdentityAdmin> Get()
        {
            return new List<IdentityAdmin>
            {
                new IdentityAdmin
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
                }
            };
        }
    }
}
