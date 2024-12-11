namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Queries.EventGigDetailed;

public class EventGigDetailedViewModel
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public DateTime Date { get; set; }
	public int Price { get; set; }
	public string[] Artist { get; set; } = [];
	public DateTime EventDate { get; set; }
	public Guid CategoryId { get; set; }
	public CategoryDto? Category { get; set; }
}
