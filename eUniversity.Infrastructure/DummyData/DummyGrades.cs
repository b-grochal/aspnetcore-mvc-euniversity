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
                    GradeId = DummySeed.NoGrade,
                    Name = "No grade"
                },
                new Grade
                {
                    GradeId = DummySeed.Grade2,
                    Name = "2"
                },
                new Grade
                {
                    GradeId = DummySeed.Grade3,
                    Name = "3"
                },
                new Grade
                {
                    GradeId = DummySeed.Grade4,
                    Name = "4"
                },
                new Grade
                {
                    GradeId = DummySeed.Grade5,
                    Name = "5"
                },
            };
        }
    }
}
