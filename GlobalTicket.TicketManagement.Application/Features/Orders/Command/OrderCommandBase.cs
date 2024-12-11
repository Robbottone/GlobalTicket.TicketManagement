using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Orders.Command;

public abstract class OrderCommandBase<TRequest, TResponse> : OrderBase, IRequestHandler<TRequest, TResponse> where TRequest : class, IRequest<TResponse>
{
	protected OrderCommandBase(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
	{
	}

	public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}

public abstract class OrderCommandBase<TRequest> : OrderBase, IRequestHandler<TRequest> where TRequest : class, IRequest
{
	protected OrderCommandBase(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
	{
	}

	public abstract Task Handle(TRequest request, CancellationToken cancellationToken);
}

public class OrderBase
{
	public IOrderRepository orderRepository;
	public IMapper mapper;

	protected OrderBase(IOrderRepository orderRepository, IMapper mapper)
	{
		this.orderRepository = orderRepository;
		this.mapper = mapper;
	}
}
