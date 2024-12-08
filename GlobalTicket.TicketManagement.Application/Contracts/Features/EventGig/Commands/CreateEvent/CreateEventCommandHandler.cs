using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.CreateEvent;

public class CreateEventCommandHandler : IRequestHandler<CreateEventGigCommand, Guid>
{
	public IEventGigRepostiory eventRepository;	
	public IMapper mapper;

	public CreateEventCommandHandler(IMapper mapper, IEventGigRepostiory eventRepository)
	{
		this.eventRepository = eventRepository;
		this.mapper = mapper;
	}

	public async Task<Guid> Handle(CreateEventGigCommand request, CancellationToken cancellationToken)
	{
		//validation


		//mapper command to model
		var @event = this.mapper.Map<EventG>(request);
		//insert
		var addedEvent = await this.eventRepository.AddAsync(@event);
		
		//return
		return addedEvent.EventId;
	}
}
