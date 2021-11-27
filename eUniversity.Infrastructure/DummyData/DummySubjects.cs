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
                    SubjectId = DummySeed.ComputerScience,
                    Name = "Computer Science"
                },
                new Subject
                {
                    SubjectId = DummySeed.Biotechnology,
                    Name = "Biotechnology"
                },
                new Subject
                {
                    SubjectId = DummySeed.Physics,
                    Name = "Physics"
                },
                new Subject
                {
                    SubjectId = DummySeed.Mathematics,
                    Name = "Mathematics"
                }
            };
        }
    }
}
