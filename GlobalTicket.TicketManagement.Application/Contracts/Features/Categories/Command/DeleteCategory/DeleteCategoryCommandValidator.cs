using FluentValidation;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.DeleteCategory;

public class DeleteCategoryCommandValidator: AbstractValidator<DeleteCategoryCommand>
{
	public DeleteCategoryCommandValidator() {
		RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} is required.");
	}
}
