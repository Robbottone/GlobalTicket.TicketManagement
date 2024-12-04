using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Response;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Request;

public class GetEventGigsListRequest : IRequest<List<EventGigViewModel>>
{

}
