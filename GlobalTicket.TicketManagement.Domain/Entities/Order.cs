namespace GlobalTicket.TicketManagement.Domain.Entities;
public class Order
{
	public Guid Id { get; set; }
	public Guid UserId { get; set; }
	public Guid EventId { get; set; }
	public int TicketAmount { get; set; }
	public DateTime OrderPlaced { get; set; }
	public bool IsPaymentSuccessful { get; set; }
}
