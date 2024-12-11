

using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Application.Features.Orders.Command;

namespace GlobalTicket.TicketManagement.Application.Features.Orders.Command.DeleteOrder;
public class DeleteOrderCommandHandler : OrderCommandBase<DeleteOrderCommand>
{
	public DeleteOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
	{
	}

	public override async Task Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		await orderRepository.GetByIdAsync(request.Id);
	}
}
