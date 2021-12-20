using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.EnrollOnCourse
{
    public class EnrollOnCourseCommand : IRequest<EnrollOnCourseCommandResponse>
    { 
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string Password { get; set; }
    }
}
