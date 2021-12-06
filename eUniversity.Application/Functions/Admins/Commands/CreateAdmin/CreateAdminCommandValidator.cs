using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Commands.CreateAdmin
{
    public class CreateAdminCommandValidator : AbstractValidator<CreateAdminCommand>
    {
        public CreateAdminCommandValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.LastName)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.Email)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.UserName)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.Password)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.ConfirmationPassword)
                .Equal(c => c.Password)
                .WithMessage("Password and confirmation password must match each other.");
        }
    }
}
