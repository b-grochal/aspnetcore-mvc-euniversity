using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummySubjects
    {
        public static List<Subject> Get()
        {
            return new List<Subject> {
                new Subject
                {
                    Name = "Computer Science"
                },
                new Subject
                {
                    Name = "Biotechnology"
                },
                new Subject
                {
                    Name = "Physics"
                },
                new Subject
                {
                    Name = "Mathematics"
                }
            };
        }
    }
}
