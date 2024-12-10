

using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Orders.Command.DeleteOrder;
public class DeleteOrderCommandHandler : OrderCommandBase<DeleteOrderCommand>
{
	public DeleteOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
	{
	}

	public override async Task Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		await this.orderRepository.GetByIdAsync(request.Id);
	}
}
