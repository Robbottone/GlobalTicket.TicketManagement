using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.CreateEvent;

public class CreateEventCommandHandler : EventCommandBase<CreateEventGigCommand, Guid>
{
	
	public CreateEventCommandHandler(IEventGigRepostiory eventRepository, IMapper mapper): base(eventRepository, mapper)
	{
	
	}

	public override async Task<Guid> Handle(CreateEventGigCommand request, CancellationToken cancellationToken)
	{
		//mapper command to model
		var @event = this.mapper.Map<EventG>(request);
		//insert
		var addedEvent = await this.eventRepository.AddAsync(@event);
		
		//return
		return addedEvent.EventId;
	}
}
