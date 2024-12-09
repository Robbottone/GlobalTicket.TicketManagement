
using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.CreateCategory;

public class CreateCategoryCommandHandler : CategoryCommandBase<CreateCategoryCommand, Guid>
{
	public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper): base(categoryRepository, mapper)
	{
	}

	public override async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var category = this.mapper.Map<Category>(request);

		var addedCategory = await this.categoryRepository.AddAsync(category);

		return addedCategory.Id;
	}
}
