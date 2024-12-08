
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;
using EnsureThat;
using System.Runtime.CompilerServices;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.DeleteEvent;

public class DeleteEventGigCommandHandler : IRequestHandler<DeleteEventGigCommand>
{
	IEventGigRepostiory eventRepostiory { get; set; }
	public DeleteEventGigCommandHandler(IEventGigRepostiory eventRepository)
	{
		this.eventRepostiory = eventRepository;
	}

	public async Task Handle(DeleteEventGigCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);
		
		var delete = await this.eventRepostiory.DeleteAsync(request.Id);
	}
}
