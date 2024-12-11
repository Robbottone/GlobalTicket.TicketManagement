using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Orders.Command.UpdateOrder;

public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
{
	public UpdateOrderCommandValidator()
	{
		RuleFor(p => p.Id)
			.NotEmpty().WithMessage("{PropertyName} is required.");
		RuleFor(p => p.UserId).NotEmpty().WithMessage("{PropertyName} is required.");
		RuleFor(p => p.EventId).NotEmpty().WithMessage("{PropertyName} is required.");
		RuleFor(p => p.TicketAmount).GreaterThan(0).WithMessage("{PropertyName} is required.");
		RuleFor(p => p.OrderPlaced).GreaterThan(new DateTime(1970, 01, 01)).WithMessage("{PropertyName} is required and it must be recent than 1970");

	}
}
