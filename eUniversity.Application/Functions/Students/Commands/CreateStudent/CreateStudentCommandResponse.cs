using eUniversity.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Commands.CreateStudent
{
    public class CreateStudentCommandResponse : BaseResponse
    {
        public int? StudentId { get; set; }

        public CreateStudentCommandResponse() : base()
        { }

        public CreateStudentCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public CreateStudentCommandResponse(string message)
        : base(message)
        { }

        public CreateStudentCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public CreateStudentCommandResponse(int studentId)
        {
            StudentId = studentId;
        }
    }
}
