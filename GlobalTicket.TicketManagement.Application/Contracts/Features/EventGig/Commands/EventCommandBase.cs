using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;

public abstract class EventCommandBase<TRequest, TResult> : CommandBase, IRequestHandler<TRequest, TResult> where TRequest: class, IRequest<TResult>
{
	protected EventCommandBase(IEventGigRepostiory eventRepository, IMapper mapper): base(eventRepository, mapper)
	{
	}
	

	abstract public Task<TResult> Handle(TRequest request, CancellationToken cancellationToken);
}

public abstract class EventCommandBase<TRequest> : CommandBase, IRequestHandler<TRequest> where TRequest: class, IRequest
{
	protected EventCommandBase(IEventGigRepostiory eventRepository, IMapper mapper) : base(eventRepository, mapper)
	{
	}
	abstract public Task Handle(TRequest request, CancellationToken cancellationToken);
}

public class CommandBase
{
	public IEventGigRepostiory eventRepository;
	public IMapper mapper;
	protected CommandBase(IEventGigRepostiory eventRepository, IMapper mapper)
	{
		this.eventRepository = eventRepository;
		this.mapper = mapper;
	}
}