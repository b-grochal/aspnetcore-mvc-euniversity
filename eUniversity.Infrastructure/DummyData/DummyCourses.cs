using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class  DummyCourses
    {
        public static List<Course> Get()
        {
            return new List<Course>
            {
                new Course
                {
                    CourseId = DummySeed.ComputerProgramming,
                    Name = "Computer programming",
                    SubjectId = DummySeed.ComputerScience,
                    SemesterId = DummySeed.FirstSemester,
                    DegreeId = DummySeed.EngineersDegree
                },
                new Course
                {
                    CourseId = DummySeed.Chemistry,
                    Name = "Chemistry",
                    SubjectId = DummySeed.Biotechnology,
                    SemesterId = DummySeed.SecondSemester,
                    DegreeId = DummySeed.EngineersDegree
                },
                new Course
                {
                    CourseId = DummySeed.Astronomy,
                    Name = "Astronomy",
                    SubjectId = DummySeed.Physics,
                    SemesterId = DummySeed.SecondSemester,
                    DegreeId = DummySeed.BachelorsDegree
                },
                new Course
                {
                    CourseId = DummySeed.LinearAlgebry,
                    Name = "Linear algebry",
                    SubjectId = DummySeed.Mathematics,
                    SemesterId = DummySeed.FirstSemester,
                    DegreeId = DummySeed.MastersDegree
                }
            };
        }
    }
}
