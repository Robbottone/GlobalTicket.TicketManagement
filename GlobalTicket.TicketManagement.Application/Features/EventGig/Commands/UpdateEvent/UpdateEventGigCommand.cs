using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.UpdateEvent
{
	public class UpdateEventGigCommand : IRequest
	{
		public Guid EventId { get; set; }
		public string Name { get; set; } = string.Empty;
		public string? Description { get; set; }
		public int Price { get; set; }
		public string[] Artist { get; set; } = [];
		public DateTime EventDate { get; set; }
		public Guid CategoryId { get; set; }
	}
}
