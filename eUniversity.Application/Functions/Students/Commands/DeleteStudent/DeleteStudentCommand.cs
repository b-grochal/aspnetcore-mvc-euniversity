using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommand : IRequest
    {
        public int StudentId { get; set; }
    }
}
