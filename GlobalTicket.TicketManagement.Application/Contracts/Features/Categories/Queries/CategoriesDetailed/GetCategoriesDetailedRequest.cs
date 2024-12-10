
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Queries.GetCategoriesDetailed;

public class GetCategoriesDetailedRequest: IRequest<IEnumerable<CategoryDetailedViewModel>>
{
	public bool includeHistory { get; set; }
}
