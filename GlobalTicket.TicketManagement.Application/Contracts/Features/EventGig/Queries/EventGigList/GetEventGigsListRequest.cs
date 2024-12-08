using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Query.EventGigList;

public class GetEventGigsListRequest : IRequest<List<EventGigViewModel>>
{

}
