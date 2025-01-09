using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using Moq;

namespace Application.UnitTest.Mocks;

public class RepositoryMocks
{
	public static Mock<ICategoryRepository> GetCategoryRepository() {

	   var concertGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
      var musicalGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
      var playGuid = Guid.Parse("{BF3F3002-7E53-441E-8B76-F6280BE284AA}");
      var conferenceGuid = Guid.Parse("{FE98F549-E790-4E9F-AA16-18C2292A2EE9}");

      var categories = new List<Category>
      {
         new Category
         {
            Id = concertGuid,
            Name = "Concerts"
         },
         new Category
         {
            Id = musicalGuid,
            Name = "Musicals"
         },
         new Category
         {
            Id = conferenceGuid,
            Name = "Conferences"
         },
         new Category
         {
            Id = playGuid,
            Name = "Plays"
         }
      };

		//devo indicare alla classe Mockata che cosa fare quando viene chiamato il metodo ListAllAsync
		var mockCategoryRepository = new Mock<ICategoryRepository>();

      mockCategoryRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(categories);
      mockCategoryRepository.Setup(repo => repo.AddAsync(It.IsAny<Category>())).ReturnsAsync((Category cat) => { 
         categories.Add(cat);
         return cat;
		});

		return mockCategoryRepository;
	}
}
