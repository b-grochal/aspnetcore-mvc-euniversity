using eUniversity.Domain.Enitities;
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
        public static List<Teacher> Get()
        {
            return new List<Teacher>
            {
                new Teacher
                {
                    TeacherId = DummySeed.Teacher,
                    FirstName = "Michael",
                    LastName = "Scott",
                    Email = "michsco123@euniversity.com",
                    UserName = "michsco123",
                    PhoneNumber = "123-456-789"
                }
            };
        }
    }
}
