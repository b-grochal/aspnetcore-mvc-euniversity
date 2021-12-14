using eUniversity.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Teachers.Commands.CreateTeacher
{
    public class CreateTeacherCommandResponse : BaseResponse
    {
        public int? TeacherId { get; set; }

        public CreateTeacherCommandResponse() : base()
        { }

        public CreateTeacherCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public CreateTeacherCommandResponse(string message)
        : base(message)
        { }

        public CreateTeacherCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public CreateTeacherCommandResponse(int studentId)
        {
            TeacherId = studentId;
        }
    }
}
