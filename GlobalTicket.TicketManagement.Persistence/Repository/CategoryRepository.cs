using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Persistence.Repository;

public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
{
	public CategoryRepository(GlobalTicketDbContext dbContext) : base(dbContext)
	{
	}

	public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
	{
		var query = this.dbContext.Categories.Include(x => x.EventGigs).AsQueryable();

		if (!includePassedEvents)
		{
			query = query.Where(x => x.EventGigs.Any(y => y.EventDate >= DateTime.Today));
		}

		return await query.ToListAsync();
	}
}
