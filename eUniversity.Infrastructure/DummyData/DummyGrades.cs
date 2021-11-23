using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyGrades
    {
        public static List<Grade> Get()
        {
            return new List<Grade>
            {
                new Grade
                {
                    Name = "No grade"
                },
                new Grade
                {
                    Name = "2"
                },
                new Grade
                {
                    Name = "3"
                },
                new Grade
                {
                    Name = "4"
                },
                new Grade
                {
                    Name = "5"
                },
            };
        }
    }
}
