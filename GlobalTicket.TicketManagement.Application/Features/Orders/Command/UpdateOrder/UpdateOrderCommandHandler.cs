using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Application.Features.Orders.Command;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Orders.Command.UpdateOrder;

public class UpdateOrderCommandHandler : OrderCommandBase<UpdateOrderCommand>
{
	public UpdateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
	{
	}

	public override async Task Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var order = mapper.Map<Order>(request);

		await orderRepository.UpdateAsync(order);
	}
}
