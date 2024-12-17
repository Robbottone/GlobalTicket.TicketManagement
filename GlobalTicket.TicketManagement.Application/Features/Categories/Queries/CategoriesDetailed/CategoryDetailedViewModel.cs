namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesDetailed;

public class CategoryDetailedViewModel
{
	public Guid Id { get; set; }
	public required string Name { get; set; }
	public required ICollection<EventGigDto> EventGigs { get; set; }
}

public class EventGigDto
{
	public Guid EventId { get; set; }
	public string Name { get; set; }
	public string? Description { get; set; }

	public EventGigDto()
	{

	}

	public EventGigDto(Guid eventId, string name, string description)
	{
		this.EventId = eventId;
		this.Name = name;
		this.Description = description;
	}

}
	
