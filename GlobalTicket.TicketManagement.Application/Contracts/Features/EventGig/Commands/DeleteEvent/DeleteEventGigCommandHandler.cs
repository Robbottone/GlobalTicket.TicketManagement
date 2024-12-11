
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;
using EnsureThat;
using System.Runtime.CompilerServices;
using AutoMapper;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.DeleteEvent;

public class DeleteEventGigCommandHandler : EventCommandBase<DeleteEventGigCommand>
{
	public DeleteEventGigCommandHandler(IEventGigRepostiory eventRepository, IMapper mapper): base(eventRepository, mapper)
	{
	}

	public override async Task Handle(DeleteEventGigCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		await this.eventRepository.DeleteAsync(request.Id);
	}
}
