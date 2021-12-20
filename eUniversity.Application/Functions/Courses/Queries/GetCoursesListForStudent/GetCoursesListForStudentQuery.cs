using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Queries.GetCoursesListForStudent
{
    public class GetCoursesListForStudentQuery : IRequest<CoursesListForStudentDto>
    {
        public int StudentId { get; set; }
        public string SearchedName { get; set; }
    }
}
