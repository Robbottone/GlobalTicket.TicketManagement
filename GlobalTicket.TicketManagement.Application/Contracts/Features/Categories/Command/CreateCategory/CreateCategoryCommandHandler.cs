
using AutoMapper;
using EnsureThat;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.CreateCategory;

public class CreateCategoryCommandHandler : CategoryCommandBase<CreateCategoryCommand, CreateCategoryCommandResponse>
{
	public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper): base(categoryRepository, mapper)
	{
	}

	public override async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
	{
		EnsureArg.IsNotNull(request);

		var createCategoryCommandResponse = new CreateCategoryCommandResponse();

		var validator = new CreateCategoryCommandValidator();
		var validationResult = await validator.ValidateAsync(request);

		if(validationResult.Errors.Any())
		{
			createCategoryCommandResponse.ValidationErrors = new List<string>();
			createCategoryCommandResponse.Success = false;
			foreach (var error in validationResult.Errors)
			{
				createCategoryCommandResponse.ValidationErrors.Add(error.ErrorMessage);
			}
		} else {
			var category = this.mapper.Map<Category>(request);

			var addedCategory = await this.categoryRepository.AddAsync(category);
			createCategoryCommandResponse.Success = true;
			createCategoryCommandResponse.Data = addedCategory;
		}

		return createCategoryCommandResponse;
	}
}
