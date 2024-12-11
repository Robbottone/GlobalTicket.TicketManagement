
using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Application.Features.Orders.Command;
using GlobalTicket.TicketManagement.Domain.Entities;

namespace GlobalTicket.TicketManagement.Application.Features.Orders.Command.CreateOrder;

public class CreateOrderCommandHandler : OrderCommandBase<CreateOrderCommand, Guid>
{
	public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
	{
	}

	public override async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
	{
		var order = mapper.Map<Order>(request);

		var addOrder = await orderRepository.AddAsync(order);

		return addOrder.Id;
	}
}
