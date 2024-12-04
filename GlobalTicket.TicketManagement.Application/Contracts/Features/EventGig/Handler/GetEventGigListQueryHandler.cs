using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using EventGigs = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
using MediatR;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Response;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Request;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Handler;

public class GetEventGigListQueryHandler : IRequestHandler<GetEventGigsListRequest, List<EventGigViewModel>>
{
	private IAsyncRepository<EventGigs> eventRepository;
	private IMapper mapper;

	public GetEventGigListQueryHandler(IMapper mapper, IAsyncRepository<EventGigs> eventRepository)
	{
		this.mapper = mapper;
		this.eventRepository = eventRepository;
	}

	public async Task<List<EventGigViewModel>> Handle(GetEventGigsListRequest request, CancellationToken cancellationToken)
	{
		var allEventGigs = (await eventRepository.ListAllAsync()).OrderBy(x => x.EventDate);
		return mapper.Map<List<EventGigViewModel>>(allEventGigs);
	}
}
