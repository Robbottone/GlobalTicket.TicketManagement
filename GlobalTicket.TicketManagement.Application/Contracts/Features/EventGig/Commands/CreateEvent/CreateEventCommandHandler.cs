using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
using MediatR;
using EnsureThat;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.CreateEvent;

public class CreateEventCommandHandler : EventCommandBase<CreateEventGigCommand, CreateEventCommandResponse>
{
	
	public CreateEventCommandHandler(IEventGigRepostiory eventRepository, IMapper mapper): base(eventRepository, mapper)
	{
	
	}

	public override async Task<CreateEventCommandResponse> Handle(CreateEventGigCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);
		var createEventCommandResponse = new CreateEventCommandResponse();

		var validator = new CreateEventGigCommandValidator();
		var validationResult = await validator.ValidateAsync(request);

		if(!validationResult.IsValid)
		{
			createEventCommandResponse.Success = false;
			createEventCommandResponse.ValidationErrors = new List<string>();
			foreach (var error in validationResult.Errors)
			{
				createEventCommandResponse.ValidationErrors.Add(error.ErrorMessage);
			}
		} else {
			//mapper command to model
			var @event = this.mapper.Map<EventG>(request);
			//insert
			var addedEvent = await this.eventRepository.AddAsync(@event);
			createEventCommandResponse.Success = true;
			createEventCommandResponse.Data = addedEvent;
		}
		
		//return
		return createEventCommandResponse;
	}
}
