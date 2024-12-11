using MediatR;
namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.DeleteEvent;

public class DeleteEventGigCommand : IRequest
{
	public Guid Id { get; set; }
}
