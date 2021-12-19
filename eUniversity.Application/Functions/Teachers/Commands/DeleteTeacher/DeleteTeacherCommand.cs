using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Teachers.Commands.DeleteTeacher
{
    public class DeleteTeacherCommand : IRequest
    {
        public int TeacherId { get; set; }
    }
}
