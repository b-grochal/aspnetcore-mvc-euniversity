using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.DeleteCourse
{
    public class DeleteCourseCommand : IRequest
    {
        public int CourseId { get; set; }
    }
}
