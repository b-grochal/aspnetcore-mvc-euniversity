using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUniversity.Application.Functions.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandValidator : AbstractValidator<CreateCourseCommand>
    {
        public CreateCourseCommandValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.Password)
                .NotEmpty()
                .WithMessage("{PorpertyName} should be not empty.");

            RuleFor(c => c.ConfirmationPassword)
                .Equal(c => c.Password)
                .WithMessage("Password and confirmation password must match each other.");

            RuleFor(c => c.DegreeId)
                .GreaterThan(0)
                .WithMessage("{PorpertyName} as foreign key should be greater than zero.");

            RuleFor(c => c.SemesterId)
                .GreaterThan(0)
                .WithMessage("{PorpertyName} as foreign key should be greater than zero.");

            RuleFor(c => c.SubjectId)
                .GreaterThan(0)
                .WithMessage("{PorpertyName} as foreign key should be greater than zero.");
        }
    }
}
