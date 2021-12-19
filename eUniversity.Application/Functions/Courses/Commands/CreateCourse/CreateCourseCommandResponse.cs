using eUniversity.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandResponse : BaseResponse
    {
        public int? CourseId { get; set; }

        public CreateCourseCommandResponse() : base()
        { }

        public CreateCourseCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public CreateCourseCommandResponse(string message)
        : base(message)
        { }

        public CreateCourseCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public CreateCourseCommandResponse(int adminId)
        {
            CourseId = adminId;
        }
    }
}
