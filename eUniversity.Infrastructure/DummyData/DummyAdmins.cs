using eUniversity.Domain.Enitities;
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
        public static List<Admin> Get()
        {
            return new List<Admin>
            {
                new Admin
                {
                    AdminId = DummySeed.Admin,
                    FirstName = "David",
                    LastName = "Wallace",
                    Email = "daviwal123@euniversity.com",
                    Username = "daviwal123",
                    PhoneNumber = "123-456-789"
                }
            };
        }
    }
}
