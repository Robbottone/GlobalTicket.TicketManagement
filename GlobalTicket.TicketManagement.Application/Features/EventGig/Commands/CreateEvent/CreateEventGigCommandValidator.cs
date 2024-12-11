using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.CreateEvent;

public class CreateEventGigCommandValidator : AbstractValidator<CreateEventGigCommand>
{
	public CreateEventGigCommandValidator()
	{
		RuleFor(p => p.Name)
			.NotEmpty().WithMessage("{PropertyName} is required.")
			.MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

		RuleFor(p => p.Description).MaximumLength(200).When(p => !string.IsNullOrEmpty(p.Description));

		RuleFor(p => p.Price)
			.GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");

		RuleFor(p => p.EventDate)
			.NotEmpty().WithMessage("{PropertyName} is required.")
			.GreaterThan(DateTime.Now).WithMessage("{PropertyName} must be greater than today.");

		RuleFor(p => p.CategoryId)
			.NotEmpty().WithMessage("{PropertyName} is required.")
			.NotEqual(Guid.Empty).WithMessage("{PropertyName} is required.");
	}
}
