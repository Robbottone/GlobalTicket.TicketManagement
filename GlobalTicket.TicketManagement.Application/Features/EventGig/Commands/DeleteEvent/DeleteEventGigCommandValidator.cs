using FluentValidation;
using System.Data;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.DeleteEvent;

public class DeleteEventGigCommandValidator : AbstractValidator<DeleteEventGigCommand>
{
	public DeleteEventGigCommandValidator()
	{
		RuleFor(p => p.Id).NotNull().NotEmpty().WithMessage("the ID of the event is required for deletion.");
	}
}
