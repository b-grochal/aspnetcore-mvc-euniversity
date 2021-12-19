using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommand : IRequest
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public int SemesterId { get; set; }
        public int DegreeId { get; set; }
    }
}
