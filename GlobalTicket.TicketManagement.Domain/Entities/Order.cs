using GlobalTicket.TicketManagement.Domain.Common;

namespace GlobalTicket.TicketManagement.Domain.Entities;
public class Order: AuditableEntity
{
	public Guid Id { get; set; }
	public Guid UserId { get; set; }
	public Guid EventId { get; set; }
	public int OrderTotal { get; set; }
	public DateTime OrderPlaced { get; set; }
	public bool OrderPaid { get; set; }
	public string CreatedBy { get; set; } = string.Empty;
}
