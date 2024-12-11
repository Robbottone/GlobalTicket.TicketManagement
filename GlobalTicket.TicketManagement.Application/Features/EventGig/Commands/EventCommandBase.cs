using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;

public abstract class EventCommandBase<TRequest, TResult> : EventBase, IRequestHandler<TRequest, TResult> where TRequest: class, IRequest<TResult>
{
	protected EventCommandBase(IEventGigRepostiory eventRepository, IMapper mapper): base(eventRepository, mapper)
	{
	}
	

	abstract public Task<TResult> Handle(TRequest request, CancellationToken cancellationToken);
}

public abstract class EventCommandBase<TRequest> : EventBase, IRequestHandler<TRequest> where TRequest: class, IRequest
{
	protected EventCommandBase(IEventGigRepostiory eventRepository, IMapper mapper) : base(eventRepository, mapper)
	{
	}
	abstract public Task Handle(TRequest request, CancellationToken cancellationToken);
}

public class EventBase
{
	public IEventGigRepostiory eventRepository;
	public IMapper mapper;

	protected EventBase(IEventGigRepostiory eventRepository, IMapper mapper)
	{
		this.eventRepository = eventRepository;
		this.mapper = mapper;
	}
}