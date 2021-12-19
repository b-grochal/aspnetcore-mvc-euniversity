using eUniversity.Application.Functions.Students.Queries.GetStudentDetails;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Teachers.Queries.GetTeacherDetails
{
    public class GetTeacherDetailsQuery : IRequest<TeacherDetailsDto>
    {
        public int Id { get; set; }
    }
}
