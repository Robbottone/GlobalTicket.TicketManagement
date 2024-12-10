using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Orders.Command.DeleteOrder;

public class DeleteOrderCommand: IRequest
{
	public Guid Id { get; set; }
}
