using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Queries.GetCategoriesDetailed;

public class GetCategoriesDetailedRequestHandler: IRequestHandler<GetCategoriesDetailedRequest, IEnumerable<CategoryDetailedViewModel>>
{
	private readonly ICategoryRepository categoryRepository;
	private readonly IEventGigRepostiory eventGigRepository;
	private readonly IMapper mapper;

	public GetCategoriesDetailedRequestHandler(IMapper mapper, ICategoryRepository categoryRepository, IEventGigRepostiory eventRepository)
	{
		this.categoryRepository = categoryRepository;
		this.eventGigRepository = eventRepository;
		this.mapper = mapper;
	}
	public async Task<IEnumerable<CategoryDetailedViewModel>> Handle(GetCategoriesDetailedRequest request, CancellationToken cancellationToken)
	{
		var categories = await this.categoryRepository.GetCategoriesWithEvents(request.includeHistory);

		return this.mapper.Map<IEnumerable<CategoryDetailedViewModel>>(categories);
	}
}
