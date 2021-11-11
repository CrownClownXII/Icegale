using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Application.Dtos;

namespace UserService.Application.Validators
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequestDto>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .MaximumLength(50)
                .EmailAddress()
                .WithMessage("Email is not valid");

            RuleFor(c => c.FirstName)
               .NotEmpty()
               .MaximumLength(50);

            RuleFor(c => c.LastName)
              .NotEmpty()
              .MaximumLength(50);

            RuleFor(c => c.Login)
              .NotEmpty()
              .MaximumLength(50);

            RuleFor(c => c.Password)
              .NotEmpty()
              .MaximumLength(50);
        }
    }
}
