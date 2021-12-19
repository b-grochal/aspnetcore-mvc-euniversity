using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.CreateCourse
{
    public class CreateCourseCommand : IRequest<CreateCourseCommandResponse>
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmationPassword { get; set; }
        public int SubjectId { get; set; }
        public int SemesterId { get; set; }
        public int DegreeId { get; set; }
    }
}
