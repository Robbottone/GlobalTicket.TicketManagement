﻿using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GlobalTicket.TicketManagement.Persistence;

public static class PersistenceServiceRegistration
{
	public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<GlobalTicketDbContext>(options =>
			options.UseSqlServer(configuration.GetConnectionString("GlobalTicketTicketManagementConnectionString"),
				b => b.MigrationsAssembly(typeof(GlobalTicketDbContext).Assembly.FullName)));
		services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
		services.AddScoped<ICategoryRepository, CategoryRepository>();
		services.AddScoped<IEventGigRepostiory, EventGigRepository>();
		services.AddScoped<IOrderRepository, OrderRepository>();
		return services;
	}
}
