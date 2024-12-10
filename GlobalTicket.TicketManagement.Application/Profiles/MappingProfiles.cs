using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.CreateCategory;
using GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Command.UpdateCategory;
using GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Queries.GetCategories;
using GlobalTicket.TicketManagement.Application.Contracts.Features.Categories.Queries.GetCategoriesDetailed;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Commands.CreateEvent;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Query.EventGigDetailed;
using GlobalTicket.TicketManagement.Application.Contracts.Features.EventGig.Query.EventGigList;
using GlobalTicket.TicketManagement.Application.Contracts.Features.Orders.Command.CreateOrder;
using GlobalTicket.TicketManagement.Application.Contracts.Features.Orders.Command.UpdateOrder;
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
