using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Response;
using GlobalTicket.TicketManagement.Domain.Entities;

namespace GlobalTicket.TicketManagement.Application.Contracts.Profiles;

public class MappingProfiles: Profile
{
	public MappingProfiles()
	{
		CreateMap<EventGig, EventGigViewModel>().ReverseMap(); //two way mapping
		CreateMap<EventGig, EventGigDetailedViewModel>().ReverseMap(); 
		CreateMap<Category, CategoryDto>().ReverseMap(); 
	}
}
