using eUniversity.Application.Functions.Courses.Queries.GetCourseDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Grades.Queries.GetGradesList
{
    public class GradesListDto
    {
        public List<GradeDto> Grades{ get; set; }
    }
}
