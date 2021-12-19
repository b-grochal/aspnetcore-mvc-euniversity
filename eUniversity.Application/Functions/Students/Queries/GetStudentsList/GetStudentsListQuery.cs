using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Queries.GetStudentsList
{
    public class GetStudentsListQuery : IRequest<StudentsListDto>
    {
        public string SearchedUserName { get; set; }
    }
}
