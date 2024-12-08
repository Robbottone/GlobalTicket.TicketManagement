using MediatR;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.CreateCategory;

public class CreateCategoryCommand: IRequest<Guid>
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public ICollection<EventG>? EventGigs { get; set; }

	public override string ToString()
	{
		return $"Category name: {Name};";
	} 
}

