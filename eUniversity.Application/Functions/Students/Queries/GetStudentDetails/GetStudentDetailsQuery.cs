using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Queries.GetStudentDetails
{
    public class GetStudentDetailsQuery : IRequest<StudentDetailsDto>
    {
        public int Id { get; set; }
    }
}
