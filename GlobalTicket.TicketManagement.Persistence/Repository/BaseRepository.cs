using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GlobalTicket.TicketManagement.Persistence.Repository;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
	protected readonly GlobalTicketDbContext dbContext;
	public BaseRepository(GlobalTicketDbContext dbContext)
	{
		this.dbContext = dbContext;
	}

	public async Task<T> AddAsync(T entity)
	{
		await this.dbContext.Set<T>().AddAsync(entity);
		await this.dbContext.SaveChangesAsync();

		return entity;
	}

	public async Task DeleteAsync(Guid id)
	{
		var entity = await this.GetByIdAsync(id);

		this.dbContext.Set<T>().Remove(entity);
	}
	public async Task UpdateAsync(T entity)
	{
		dbContext.Entry(entity).State = EntityState.Modified;
		await dbContext.SaveChangesAsync();
	}

	public async Task<T> GetByIdAsync(Guid id)
	{
		return await this.dbContext.Set<T>().FindAsync(id);
	}

	public async Task<IReadOnlyList<T>> ListAllAsync()
	{
		return await this.dbContext.Set<T>().ToListAsync();
	}

}
