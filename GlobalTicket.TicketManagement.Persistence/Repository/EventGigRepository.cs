using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Persistence.Repository;

public class EventGigRepository : BaseRepository<EventGig>, IEventGigRepostiory
{
	public EventGigRepository(GlobalTicketDbContext dbContext) : base(dbContext)
	{
	}

	public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
	{
		var matches = this.dbContext.Set<EventGig>().Any(ev => ev.Name.Equals(name) && ev.EventDate.Equals(eventDate.Date));

		return Task.FromResult(matches);
	}
}
