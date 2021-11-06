using eUniversity.Application.Responses;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Auth.Commands.Login
{
    public class LoginCommandResponse : BaseResponse
    {
        public LoginCommandResponse() : base()
        { }

        public LoginCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public LoginCommandResponse(string message)
        : base(message)
        { }

        public LoginCommandResponse(string message, bool success)
            : base(message, success)
        { }
    }
}
