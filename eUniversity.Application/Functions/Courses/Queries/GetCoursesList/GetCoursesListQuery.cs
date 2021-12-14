using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesList
{
    public class GetCoursesListQuery : IRequest<CoursesListDto>
    {
        public string SearchedName { get; set; }
    }
}
