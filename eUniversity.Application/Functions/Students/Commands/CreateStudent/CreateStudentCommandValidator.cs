using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Students.Commands.CreateStudent
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
    {
        public CreateStudentCommandValidator()
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
