using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.DeleteCategory;

public class DeleteCategoryCommandHandler: CategoryCommandBase<DeleteCategoryCommand>
{
	public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper) : base(categoryRepository, mapper)
	{
	}

	public override async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var categoryToDelete = await this.categoryRepository.GetByIdAsync(request.Id);
	}
}