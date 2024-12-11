using MediatR;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Command.UpdateCategory;

public class UpdateCategoryCommand : IRequest
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public ICollection<EventG>? EventGigs { get; set; }
}
