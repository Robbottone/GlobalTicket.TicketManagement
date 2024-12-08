using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Query.EventGigDetailed;

public class GetEventGigDetailedRequestHandler : IRequestHandler<GetEventGigDetailedRequest, EventGigDetailedViewModel>
{
	private IAsyncRepository<Domain.Entities.EventGig> eventRepository;
	private IAsyncRepository<Category> eventCategory;
	private IMapper mapper;

	public GetEventGigDetailedRequestHandler(IMapper mapper, IAsyncRepository<Domain.Entities.EventGig> eventRepository, IAsyncRepository<Category> eventCategory)
	{
		this.mapper = mapper;
		this.eventRepository = eventRepository;
		this.eventCategory = eventCategory;
	}

	public async Task<EventGigDetailedViewModel> Handle(GetEventGigDetailedRequest request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var @eventGig = await eventRepository.GetByIdAsync(request.Id);
		var eventDetailedDto = mapper.Map<EventGigDetailedViewModel>(@eventGig);

		var category = await eventCategory.GetByIdAsync(@eventGig.CategoryId);
		eventDetailedDto.Category = mapper.Map<CategoryDto>(category);

		return mapper.Map<EventGigDetailedViewModel>(eventGig);
	}
}
