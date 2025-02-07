﻿using MediatR;
using EventG = GlobalTicket.TicketManagement.Domain.Entities.EventGig;
namespace GlobalTicket.TicketManagement.Application.Features.Categories.Command.CreateCategory;

public class CreateCategoryCommand : IRequest<CreateCategoryCommandResponse>
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public ICollection<EventG>? EventGigs { get; set; }

	public override string ToString()
	{
		return $"Category name: {Name};";
	}
}

