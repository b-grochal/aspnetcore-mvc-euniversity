using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Auth.Commands.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(c => c.Username)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.Password)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");
        }
    }
}
