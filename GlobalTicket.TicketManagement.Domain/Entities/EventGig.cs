using GlobalTicket.TicketManagement.Domain.Common;

namespace GlobalTicket.TicketManagement.Domain.Entities;
public class EventGig: AuditableEntity
{
	public required Guid Id       { get; set; }
	public string Name        { get; set; } = string.Empty;
	public string? Description { get; set; }
	public int Price          { get; set; }
	public string[] Artist    { get; set; } = [];
	public DateTime EventDate      { get; set; }
	public Guid CategoryId    { get; set; }
	public Category? Category { get; set; }
	public string CreatedBy { get; set; } = string.Empty;
}
