using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
using MediatR;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Infrastructure;
using GlobalTicket.TicketManagement.Application.Models.Mail;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.CreateEvent;

public class CreateEventCommandHandler : EventCommandBase<CreateEventGigCommand, CreateEventCommandResponse>
{
	private IEmailService emailService;

	public CreateEventCommandHandler(IEventGigRepostiory eventRepository, IMapper mapper, IEmailService emailService) : base(eventRepository, mapper)
	{
		this.emailService = emailService;
	}

	public override async Task<CreateEventCommandResponse> Handle(CreateEventGigCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);
		var createEventCommandResponse = new CreateEventCommandResponse();

		var validator = new CreateEventGigCommandValidator();
		var validationResult = await validator.ValidateAsync(request);

		if (!validationResult.IsValid)
		{
			createEventCommandResponse.Success = false;
			createEventCommandResponse.ValidationErrors = new List<string>();
			foreach (var error in validationResult.Errors)
			{
				createEventCommandResponse.ValidationErrors.Add(error.ErrorMessage);
			}
		}
		else
		{
			//mapper command to model
			var @event = mapper.Map<EventG>(request);
			//insert
			var addedEvent = await eventRepository.AddAsync(@event);

			try {//fire and forget the sendemail
			await this.emailService.SendEmail(new Email()
			{
				To = "Cal.Duccio@gmail.com",
				Subject = "Event Created",
				Body = $"A new event was created: {request}"
			});
			}
			catch (Exception ex)
			{
				//log - application must not fail because of email sending
			}

			createEventCommandResponse.Success = true;
			createEventCommandResponse.Data = addedEvent;
		}

		//return
		return createEventCommandResponse;
	}
}
