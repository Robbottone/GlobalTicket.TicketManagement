using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Query.EventGigDetailed;

public class GetEventGigDetailedRequest : IRequest<EventGigDetailedViewModel>
{
	public Guid Id { get; set; }
}
