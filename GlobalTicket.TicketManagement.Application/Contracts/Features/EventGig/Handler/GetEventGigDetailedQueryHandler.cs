using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Request;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Response;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Handler;

public class GetEventGigDetailedQueryHandler : IRequestHandler<GetEventGigDetailedRequest, EventGigDetailedViewModel>
{
	private IAsyncRepository<Domain.Entities.EventGig> eventRepository;
	private IAsyncRepository<Category> eventCategory;
	private IMapper mapper;

	public GetEventGigDetailedQueryHandler(IMapper mapper, IAsyncRepository<Domain.Entities.EventGig> eventRepository, IAsyncRepository<Domain.Entities.Category> eventCategory)
	{
		this.mapper = mapper;
		this.eventRepository = eventRepository;
		this.eventCategory = eventCategory;
	}

	public async Task<EventGigDetailedViewModel?> Handle(GetEventGigDetailedRequest request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var @eventGig = await eventRepository.GetByIdAsync(request.Id);
		var eventDetailedDto = this.mapper.Map<EventGigDetailedViewModel>(@eventGig);	
		
		var category = await this.eventCategory.GetByIdAsync(@eventGig.CategoryId);
		eventDetailedDto.Category = this.mapper.Map<CategoryDto>(category);

		return mapper.Map<EventGigDetailedViewModel>(eventGig);
	}
}
