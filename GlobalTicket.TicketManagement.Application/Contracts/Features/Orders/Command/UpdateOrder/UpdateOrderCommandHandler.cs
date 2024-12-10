using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Orders.Command.UpdateOrder;

public class UpdateOrderCommandHandler : OrderCommandBase<UpdateOrderCommand>
{
	public UpdateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
	{
	}

	public override async Task Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var order = this.mapper.Map<Order>(request);

		await this.orderRepository.UpdateAsync(order);
	}
}
