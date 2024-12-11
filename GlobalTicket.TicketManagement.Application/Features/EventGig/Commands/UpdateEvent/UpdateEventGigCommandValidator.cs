using FluentValidation;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.UpdateEvent;

public class UpdateEventGigCommandValidator : AbstractValidator<UpdateEventGigCommand>
{
	public UpdateEventGigCommandValidator()
	{
		RuleFor(p => p.Artist).NotEmpty().WithMessage("{propertyName} must contain at least of artist");
		RuleFor(p => p.Price).GreaterThan(0).WithMessage("{propertyName} must be greater than 0");
		RuleFor(p => p.Name).NotEmpty().WithMessage("{propertyName} must contain at least of name");
		RuleFor(p => p.Description).NotEmpty().WithMessage("{propertyName} must contain at least the description");
		RuleFor(p => p.EventDate).GreaterThan(new DateTime(1970, 1, 1));
	}
}
