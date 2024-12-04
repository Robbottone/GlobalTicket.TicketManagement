using GlobalTicket.TicketManagement.Domain.Common;

namespace GlobalTicket.TicketManagement.Domain.Entities;

public class Category: AuditableEntity
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public ICollection<EventGig>? EventGigs { get; set; }
}
