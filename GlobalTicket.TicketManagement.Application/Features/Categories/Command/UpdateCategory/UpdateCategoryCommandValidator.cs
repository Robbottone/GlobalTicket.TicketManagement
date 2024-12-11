using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Command.UpdateCategory;

public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
{
	public UpdateCategoryCommandValidator()
	{
		RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required.")
			.MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

		RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} is required.");

		RuleFor(p => p.EventGigs).NotEmpty().WithMessage("{PropertyName} is required.");
	}
}
