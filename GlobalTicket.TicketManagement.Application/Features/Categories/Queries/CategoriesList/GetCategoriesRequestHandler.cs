using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesList;

public class GetCategoriesRequestHandler : IRequestHandler<GetCategoriesRequest, List<CategoryViewModel>>
{
	private ICategoryRepository categoryRepository;
	private IMapper mapper;

	public GetCategoriesRequestHandler(IMapper mapper, ICategoryRepository categoryRepository)
	{
		this.mapper = mapper;
		this.categoryRepository = categoryRepository;
	}

	public async Task<List<CategoryViewModel>> Handle(GetCategoriesRequest request, CancellationToken cancellationToken)
	{
		var categories = (await categoryRepository.ListAllAsync()).OrderBy(el => el.Name);

		return mapper.Map<List<CategoryViewModel>>(categories);
	}
}
