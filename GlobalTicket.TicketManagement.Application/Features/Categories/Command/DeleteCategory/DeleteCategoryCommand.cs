using MediatR;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Command.DeleteCategory;

public class DeleteCategoryCommand : IRequest
{
	public Guid Id { get; set; }
}
