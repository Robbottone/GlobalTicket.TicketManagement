using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;


namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.UpdateCategory;

public class UpdateCategoryCommandHandler : CategoryCommandBase<UpdateCategoryCommand>
{
	public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper) : base(categoryRepository, mapper)
	{
	}

	public override async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var category = this.mapper.Map<Category>(request);

		await this.categoryRepository.UpdateAsync(category);
	}
}
