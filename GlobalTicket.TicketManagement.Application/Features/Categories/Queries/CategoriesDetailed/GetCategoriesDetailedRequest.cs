using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesDetailed;

public class GetCategoriesDetailedRequest : IRequest<IEnumerable<CategoryDetailedViewModel>>
{
	public GetCategoriesDetailedRequest(bool includeHistory = false)
	{
		this.includeHistory = includeHistory;
	}	

	public bool includeHistory { get; set; }
}
