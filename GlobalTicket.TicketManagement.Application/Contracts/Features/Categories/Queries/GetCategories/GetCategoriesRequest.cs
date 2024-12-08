using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Queries.GetCategories;

public class GetCategoriesRequest(): IRequest<List<CategoryViewModel>>;
