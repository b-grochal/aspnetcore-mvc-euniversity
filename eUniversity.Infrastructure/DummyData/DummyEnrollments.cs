using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyEnrollments
    {
        public static List<Enrollment> Get()
        {
            return new List<Enrollment>
            {
                new Enrollment
                {
                    EnrollmentId = DummySeed.FirstEnrollment,
                    GradeId = DummySeed.NoGrade,
                    CourseId = DummySeed.ComputerProgramming,
                    StudentId = DummySeed.Student
                }
            };
        }
    }
}
