namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Response;

public class EventGigViewModel
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public DateTime Date { get; set; }
}
