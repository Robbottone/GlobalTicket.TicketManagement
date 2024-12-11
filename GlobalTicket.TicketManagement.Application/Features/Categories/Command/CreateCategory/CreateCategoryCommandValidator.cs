using FluentValidation;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Command.CreateCategory;

public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
	public CreateCategoryCommandValidator()
	{
		RuleFor(p => p.Name)
			.NotEmpty().WithMessage("{PropertyName} is required.")
			.MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

		RuleFor(p => p.EventGigs)
			.NotEmpty().WithMessage("{PropertyName} is required.");
	}
}
