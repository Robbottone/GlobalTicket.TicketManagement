using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Orders.Command.DeleteOrder;

public class DeleteOrderCommand : IRequest
{
	public Guid Id { get; set; }
}
