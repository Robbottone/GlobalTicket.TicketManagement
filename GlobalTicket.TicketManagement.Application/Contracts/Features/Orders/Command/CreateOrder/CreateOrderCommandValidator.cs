using FluentValidation;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.Orders.Command.CreateOrder;

public class CreateOrderCommandValidator: AbstractValidator<CreateOrderCommand>
{
	public CreateOrderCommandValidator() {
		RuleFor(p => p.UserId).NotEmpty().WithMessage("{PropertyName} is required.");
		RuleFor(p => p.EventId).NotEmpty().WithMessage("{PropertyName} is required.");
		RuleFor(p => p.TicketAmount).GreaterThan(0).WithMessage("{PropertyName} is required and must be greater than 0.");
		RuleFor(p => p.OrderPlaced).NotEmpty().GreaterThan(DateTime.Now.Subtract(new TimeSpan(31,0,0,0))).WithMessage("{PropertyName} is required and the date can be not older than one month");
	}
}