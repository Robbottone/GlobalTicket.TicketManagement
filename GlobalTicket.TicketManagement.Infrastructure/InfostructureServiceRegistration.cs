using Application.Contracts.Infrastructure;
using GlobalTicket.TicketManagement.Application.Contracts.Infrastructure;
using GlobalTicket.TicketManagement.Application.Models.Mail;
using GlobalTicket.TicketManagement.Infrastructure.Mail;
using Infrastructure.CsvExporter;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GlobalTicket.TicketManagement.Infrastructure;

public static class InfostructureServiceRegistration
{
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
	{
		//configurazione dell-email settings tramite file json apposito
		services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
		// Add email service
		services.AddTransient<IEmailService, EmailService>();
		services.AddTransient<ICsvExporter, CsvExport>();

		return services;
	}
}
