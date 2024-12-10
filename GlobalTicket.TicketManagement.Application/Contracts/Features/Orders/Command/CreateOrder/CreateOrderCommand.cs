using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Orders.Command.CreateOrder;

public class CreateOrderCommand: IRequest<Guid>
{
	public Guid UserId { get; set; }
	public Guid EventId { get; set; }
	public int TicketAmount { get; set; }
	public DateTime OrderPlaced { get; set; }
	public bool IsPaymentSuccessful { get; set; }
}
