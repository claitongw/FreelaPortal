using DevFreela.Application.Commands.CreateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description)
                .MaximumLength(255)
                .WithMessage("Max Description lenght is 255 characters");

            RuleFor(p => p.Title)
                .MaximumLength(30)
                .WithMessage("Max Title lenght is 30 characters");
        }
    }
}