using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesDetailed;

public class GetCategoriesDetailedRequestHandler : IRequestHandler<GetCategoriesDetailedRequest, IEnumerable<CategoryDetailedViewModel>>
{
	private readonly ICategoryRepository categoryRepository;
	private readonly IEventGigRepostiory eventGigRepository;
	private readonly IMapper mapper;

	public GetCategoriesDetailedRequestHandler(IMapper mapper, ICategoryRepository categoryRepository, IEventGigRepostiory eventRepository)
	{
		this.categoryRepository = categoryRepository;
		eventGigRepository = eventRepository;
		this.mapper = mapper;
	}
	public async Task<IEnumerable<CategoryDetailedViewModel>> Handle(GetCategoriesDetailedRequest request, CancellationToken cancellationToken)
	{
		var categories = await categoryRepository.GetCategoriesWithEvents(request.includeHistory);

		return mapper.Map<IEnumerable<CategoryDetailedViewModel>>(categories);
	}
}
