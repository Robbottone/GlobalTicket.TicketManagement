using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.UpdateEvent;

public class UpdateEventGigCommandHandler : EventCommandBase<UpdateEventGigCommand> 
{
	public UpdateEventGigCommandHandler(IEventGigRepostiory eventRepository, IMapper mapper) : base(eventRepository, mapper)
	{
	}

	public override async Task Handle(UpdateEventGigCommand request, CancellationToken cancellationToken)
	{	
		var @event = this.mapper.Map<EventG>(request);

		var updatedEvent = await this.eventRepository.UpdateAsync(@event);
	}
}
