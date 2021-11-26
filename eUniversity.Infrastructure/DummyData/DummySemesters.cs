using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummySemesters
    {
        public static List<Semester> Get()
        {
            return new List<Semester>
            {
                new Semester
                {
                    SemesterId = DummySeed.FirstSemester,
                    Name = "First"
                },
                new Semester
                {
                    SemesterId = DummySeed.SecondSemester,
                    Name = "Second"
                },
                new Semester
                {
                    SemesterId = DummySeed.ThirdSemester,
                    Name = "Third"
                },
                new Semester
                {
                    SemesterId = DummySeed.FourthSemester,
                    Name = "Fourth"
                },
                new Semester
                {
                    SemesterId = DummySeed.FifthSemester,
                    Name = "Fifth"
                },
                new Semester
                {
                    SemesterId = DummySeed.SixthSemester,
                    Name = "Sixth"
                },
                new Semester
                {
                    SemesterId = DummySeed.SeventhSemester,
                    Name = "Seventh"
                },
                new Semester
                {
                    SemesterId = DummySeed.EighthSemester,
                    Name = "Eighth"
                },
                new Semester
                {
                    SemesterId = DummySeed.NinthSemester,
                    Name = "Ninth"
                },
                new Semester
                {
                    SemesterId = DummySeed.TenthSemester,
                    Name = "Tenth"
                }
            };
        }
    }
}
