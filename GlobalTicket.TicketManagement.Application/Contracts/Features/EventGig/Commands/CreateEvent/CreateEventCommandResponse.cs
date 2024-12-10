using GlobalTicket.TicketManagement.Application.Contracts.Responses;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.CreateEvent;

public class CreateEventCommandResponse: BaseResponse<EventG>
{
}
