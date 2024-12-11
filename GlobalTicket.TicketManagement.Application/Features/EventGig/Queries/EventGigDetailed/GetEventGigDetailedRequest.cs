using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Queries.EventGigDetailed;

public class GetEventGigDetailedRequest : IRequest<EventGigDetailedViewModel>
{
	public Guid Id { get; set; }
}
