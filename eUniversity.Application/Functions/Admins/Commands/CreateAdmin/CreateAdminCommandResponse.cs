using eUniversity.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Commands.CreateAdmin
{
    public class CreateAdminCommandResponse : BaseResponse
    {
        public int? AdminId { get; set; }

        public CreateAdminCommandResponse() : base()
        { }

        public CreateAdminCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public CreateAdminCommandResponse(string message)
        : base(message)
        { }

        public CreateAdminCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public CreateAdminCommandResponse(int adminId)
        {
            AdminId = adminId;
        }
    }
}
