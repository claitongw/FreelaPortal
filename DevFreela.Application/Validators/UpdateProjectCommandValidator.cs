using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
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