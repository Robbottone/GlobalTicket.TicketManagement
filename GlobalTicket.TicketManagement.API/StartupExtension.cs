using GlobalTicket.TicketManagement.Application;
using GlobalTicket.TicketManagement.Persistence;
using GlobalTicket.TicketManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace GlobalTicket.TicketManagement.API;

public static class StartupExtension
{
	public static WebApplication ConfigureService(this WebApplicationBuilder builder) 
	{
		builder.Services.AddApplicationServices();
		builder.Services.AddPersistenceServices(builder.Configuration);
		builder.Services.AddInfrastructureServices(builder.Configuration);

		builder.Services.AddControllers();
		builder.Services.AddCors(opts => { 
			opts.AddPolicy("open", 
			policy => policy.WithOrigins([builder.Configuration["ApiUrl"] ?? "https://localhost:8720", builder.Configuration["BlazorUrl"] ?? "https://localhost:8020"])
				.AllowAnyHeader()
				.AllowAnyMethod()
				.AllowCredentials()
				.SetIsOriginAllowed(pol => true));
		});

		return builder.Build();
	}

	public static WebApplication ConfigurePipelines(this WebApplication app)
	{
		app.UseCors("open");
		app.UseHttpsRedirection();
		app.MapControllers();

		//app.UseEndpoints(endpoints =>
		//{
		//	endpoints.MapControllers();
		//});

		return app;
	}

	public static async Task ResetDatabaseAsync(this WebApplication app)
	{
		using var scope = app.Services.CreateScope();
		
		try
		{
			var context = scope.ServiceProvider.GetService<GlobalTicketDbContext>();

			if(context != null) {
				await context.Database.EnsureDeletedAsync();
				await context.Database.MigrateAsync();
			}
		}
		catch(Exception ex){}
	}
}
