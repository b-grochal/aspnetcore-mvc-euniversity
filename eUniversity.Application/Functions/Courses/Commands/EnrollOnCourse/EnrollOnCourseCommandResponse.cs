using eUniversity.Application.Responses;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.EnrollOnCourse
{
    public class EnrollOnCourseCommandResponse : BaseResponse
    {
        public int? CourseId { get; set; }

        public EnrollOnCourseCommandResponse() : base()
        { }

        public EnrollOnCourseCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public EnrollOnCourseCommandResponse(string message)
        : base(message)
        { }

        public EnrollOnCourseCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public EnrollOnCourseCommandResponse(int courseId)
        {
            CourseId = courseId;
        }
    }
}
