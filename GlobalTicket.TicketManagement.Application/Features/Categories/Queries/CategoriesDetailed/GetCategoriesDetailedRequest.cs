using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesDetailed;

public class GetCategoriesDetailedRequest : IRequest<IEnumerable<CategoryDetailedViewModel>>
{
	public bool includeHistory { get; set; }
}
