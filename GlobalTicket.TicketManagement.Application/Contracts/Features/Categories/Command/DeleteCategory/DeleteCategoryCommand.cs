using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.DeleteCategory;

public class DeleteCategoryCommand: IRequest
{
	public Guid Id { get; set; }
}
