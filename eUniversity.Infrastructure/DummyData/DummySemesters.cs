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
                    Name = "First"
                },
                new Semester
                {
                    Name = "Second"
                },
                new Semester
                {
                    Name = "Third"
                },
                new Semester
                {
                    Name = "Fourth"
                },
                new Semester
                {
                    Name = "Fifth"
                },
                new Semester
                {
                    Name = "Sixth"
                },
                new Semester
                {
                    Name = "Seventh"
                },
                new Semester
                {
                    Name = "Eighth"
                },
                new Semester
                {
                    Name = "Ninth"
                },
                new Semester
                {
                    Name = "Tenth"
                }
            };
        }
    }
}
