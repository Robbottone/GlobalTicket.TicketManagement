using GlobalTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.CreateEvent;

public class CreateEventGigCommand: IRequest<Guid>
{
	public required string Name    { get; set; }
	public string? Description     { get; set; }
	public int Price               { get; set; }
	public string[] Artists         { get; set; } = [];
	public DateTime EventDate      { get; set; }
	public Guid CategoryId         { get; set; }
	public Category? Category      { get; set; }

	public override string ToString()
	{
		return $"Event name: {Name}; Price: {Price}; By: {string.Join(",", this.Artists)}; On: {EventDate.ToShortDateString()}; Description: {Description}";
	}
}
