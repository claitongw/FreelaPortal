using DevFreela.Application.Commands.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.Email).EmailAddress().WithMessage("Email not valid");
            RuleFor(p => p.Password).Must(ValidPassword).WithMessage("Password Invalid");
            RuleFor(p => p.FullName).NotEmpty().NotNull().Must(ValidName).WithMessage("Name Invalid");
        }

        private bool ValidName(string fullName)
        {
            return fullName.Split(" ").Length > 1;
        }

        private bool ValidPassword(string password)
        {
            return password is not null;
        }
    }
}
