namespace GlobalTicket.TicketManagement.Domain.Entities;
public class EventGig
{
	public Guid EventId       { get; set; }
	public string Name        { get; set; } = string.Empty;
	public string? Description { get; set; }
	public int Price          { get; set; }
	public string[] Artist    { get; set; } = [];
	public DateTime Date      { get; set; }
	public Guid CategoryId    { get; set; }
}
