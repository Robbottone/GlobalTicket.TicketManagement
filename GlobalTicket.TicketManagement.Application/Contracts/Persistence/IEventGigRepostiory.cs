using GlobalTicket.TicketManagement.Domain.Entities;

namespace GlobalTicket.TicketManagement.Application.Contracts.Persistence;

public interface IEventGigRepostiory: IAsyncRepository<EventGig>
{
	Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
}
