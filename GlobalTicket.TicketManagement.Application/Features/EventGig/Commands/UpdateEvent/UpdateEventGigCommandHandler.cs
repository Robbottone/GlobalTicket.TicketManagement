using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
using MediatR;
using Application.Features.EventGig.Commands.UpdateEvent;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.UpdateEvent;

public class UpdateEventGigCommandHandler : EventCommandBase<UpdateEventGigCommand>
{
	public UpdateEventGigCommandHandler(IEventGigRepostiory eventRepository, IMapper mapper) : base(eventRepository, mapper)
	{
	}

	public override async Task Handle(UpdateEventGigCommand request, CancellationToken cancellationToken)
	{
		var @event = mapper.Map<EventG>(request);

		var updateResponse = new UpdateEventGigCommandResponse();
		var validator = new UpdateEventGigCommandValidator();
		var validationResult = await validator.ValidateAsync(request);

		if(!validationResult.IsValid) {
			updateResponse.Success = false;
			updateResponse.ValidationErrors = validationResult.Errors.Select(el => el.ErrorMessage).ToList();
		} else {
			updateResponse.Success = true;
			await eventRepository.UpdateAsync(@event);
		}
	}
}
