using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesList;

public class GetCategoriesRequest() : IRequest<List<CategoryViewModel>>;
