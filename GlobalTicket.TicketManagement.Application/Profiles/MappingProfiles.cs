using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Categories.Command.CreateCategory;
using GlobalTicket.TicketManagement.Application.Features.Categories.Command.UpdateCategory;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesDetailed;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.CategoriesList;
using GlobalTicket.TicketManagement.Application.Features.EventGig.Commands.CreateEvent;
using GlobalTicket.TicketManagement.Application.Features.EventGig.Queries.EventGigDetailed;
using GlobalTicket.TicketManagement.Application.Features.EventGig.Queries.EventGigList;
using GlobalTicket.TicketManagement.Application.Features.Orders.Command.CreateOrder;
using GlobalTicket.TicketManagement.Application.Features.Orders.Command.UpdateOrder;
using GlobalTicket.TicketManagement.Domain.Entities;

namespace GlobalTicket.TicketManagement.Application.Profiles;

public class MappingProfiles : Profile
{
	public MappingProfiles()
	{
		CreateMap<EventGig, EventGigViewModel>().ReverseMap(); //two way mapping
		CreateMap<EventGig, EventGigDetailedViewModel>().ReverseMap();
		CreateMap<EventGig, CreateEventGigCommand>().ReverseMap();

		CreateMap<Category, CategoryDto>();
		CreateMap<Category, CategoryViewModel>();
		CreateMap<Category, CategoryDetailedViewModel>().ReverseMap();

		CreateMap<Category, CreateCategoryCommand>();
		CreateMap<Category, UpdateCategoryCommand>().ReverseMap();

		CreateMap<Order, CreateOrderCommand>().ReverseMap();
		CreateMap<Order, UpdateOrderCommand>().ReverseMap();
	}
}
