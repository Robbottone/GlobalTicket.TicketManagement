using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace GlobalTicket.TicketManagement.Application;

public static class ServiceCollectionRegistration
{
	public static IServiceCollection AddServices(this IServiceCollection services)
	{
		services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
		services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

		services.AddFluentValidatorsByFilter();

		return services;
	}

	private static void AddFluentValidatorsByFilter(this IServiceCollection services)
	{
		// Get all assemblies
		var assemblies = AppDomain.CurrentDomain.GetAssemblies();

		foreach (var assembly in assemblies)
		{
			var validators = assembly.GetTypes()
					.Where(type =>
						typeof(IValidator).IsAssignableFrom(type) && // Ensure the type implements IValidator
						type.IsClass &&
						type.Namespace != null &&
						type.Namespace.Contains("GlobalTicket.TicketManagement.Application.Contracts.Features") &&
						(type.Name.Contains("CommandValidator"))
					);

			foreach (var validator in validators)
			{
				var interfaceType = validator.GetInterfaces()
					.FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IValidator<>));

				if (interfaceType != null)
				{
					services.AddScoped(interfaceType, validator);
				}
			}
		}
	}
}
