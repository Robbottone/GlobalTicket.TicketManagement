using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Application.Features.Categories.Command;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Command.DeleteCategory;

public class DeleteCategoryCommandHandler : CategoryCommandBase<DeleteCategoryCommand>
{
	public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper) : base(categoryRepository, mapper)
	{
	}

	public override async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var categoryToDelete = await categoryRepository.GetByIdAsync(request.Id);
	}
}