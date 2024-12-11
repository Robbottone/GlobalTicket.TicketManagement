using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Queries.EventGigList;

public class GetEventGigsListRequest : IRequest<List<EventGigViewModel>>
{

}
