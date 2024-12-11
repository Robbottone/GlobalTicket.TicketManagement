namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesDetailed;

public class CategoryDetailedViewModel
{
	public Guid Id { get; set; }
	public required string Name { get; set; }
	public required ICollection<EventGigDto> eventGigs { get; set; }
}

public record EventGigDto(Guid EventId, string Name, string Description);
