namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Queries.GetCategories;

public class CategoryViewModel
{
	public Guid Id { get; set; }
	public required string Name { get; set; }
}
