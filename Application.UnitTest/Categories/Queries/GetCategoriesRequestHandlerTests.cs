using Application.UnitTest.Mocks;
using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Application.Features.Categories.Command.CreateCategory;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesList;
using GlobalTicket.TicketManagement.Application.Profiles;
using GlobalTicket.TicketManagement.Domain.Entities;
using Moq;
using Shouldly;
using Xunit;

namespace Application.UnitTest.Categories.Queries;


public class GetCategoriesRequestHandlerTests
{
	private readonly Mock<ICategoryRepository> mockCategoryRepository;
	private readonly IMapper mapper;

	public GetCategoriesRequestHandlerTests()
	{
		this.mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
		var configurationProvider = new MapperConfiguration(cfg => {
			cfg.AddProfile<MappingProfiles>();
		});

		this.mapper = configurationProvider.CreateMapper();
	}

	[Fact]
	public async void GetCategoriesListTest()
	{
		// creare l'handler
		var handler = new GetCategoriesRequestHandler(this.mapper, this.mockCategoryRepository.Object);
		// una volta creato l'handler, possiamo chiamare il metodo Handle
		var result = await handler.Handle(new GetCategoriesRequest(), new System.Threading.CancellationToken());
		// assert
		result.ShouldBeOfType<List<CategoryViewModel>>();

		result.Count.ShouldBe(4);
	}

	[Fact]
	public async void AddBadFormedCategoryToRepository() {

		// creare l'handler per il comando di crazione 
		var handler = new CreateCategoryCommandHandler(this.mockCategoryRepository.Object, this.mapper);

		// creare il comando
		var createCategoryCommand = new CreateCategoryCommand() { Name = "BobCorn" };

		// chiamare il metodo Handle
		var result = await handler.Handle(createCategoryCommand, CancellationToken.None);

		result.ShouldNotBeNull();
		result.ValidationErrors.Count.ShouldBe(1);
	}

	[Fact]
	public async void AddCorrectCategoryToRepository() {

		// creare l'handler per il comando di crazione 
		var handler = new CreateCategoryCommandHandler(this.mockCategoryRepository.Object, this.mapper);
		// creare il comando
		var createCategoryCommand = new CreateCategoryCommand() {
			Name = "BobCorn", 
			EventGigs = new List<EventGig>() {	new EventGig() { Id = Guid.NewGuid()}}
		};

		// chiamare il metodo Handle
		var result = await handler.Handle(createCategoryCommand, CancellationToken.None);

		result.ShouldNotBeNull();
		result.Data.ShouldBeOfType<Category>();
	}

		[Fact]
	public async void AddCategoryCountListAll() {

		// creare l'handler per il comando di crazione 
		var handlerCreate = new CreateCategoryCommandHandler(this.mockCategoryRepository.Object, this.mapper);
		var handlerListAll = new GetCategoriesRequestHandler(this.mapper, this.mockCategoryRepository.Object);

		// creare il comando
		var createCategoryCommand = new CreateCategoryCommand() {
			Name = "BobCorn", 
			EventGigs = new List<EventGig>() {	new EventGig() { Id = Guid.NewGuid()}}
		};

		// chiamare il metodo Handle
		var result = await handlerCreate.Handle(createCategoryCommand, CancellationToken.None);

		handlerListAll.Handle(new GetCategoriesRequest(), CancellationToken.None).Result.Count.ShouldBe(5);
	}
}
