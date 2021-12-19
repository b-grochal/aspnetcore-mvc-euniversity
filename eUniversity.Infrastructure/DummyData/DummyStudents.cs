using eUniversity.Domain.Enitities;
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
        public static List<Student> Get()
        {
            return new List<Student>
            {
                new Student
                {
                    StudentId = DummySeed.Student,
                    FirstName = "Dwight",
                    LastName = "Schrute",
                    Email = "dwigsch123@euniversity.com",
                    UserName = "dwigsch123",
                    PhoneNumber = "123-456-789"
                }
            };
        }
    }
}
