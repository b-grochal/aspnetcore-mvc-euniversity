using eUniversity.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Infrastructure.DummyData
{
    public class DummyDegrees
    {
        public static List<Degree> Get()
        {
            return new List<Degree>
            {
                new Degree
                {
                    Name = "Bachelor's degree"
                },
                new Degree
                {
                    Name = "Engineer's degree"
                },
                new Degree
                {
                    Name = "Master's degree"
                }
            };
        }
    }
}
