using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Persistence.Repository;

public class OrderRepository: BaseRepository<Order>, IOrderRepository
{
	public OrderRepository(GlobalTicketDbContext dbContext) : base(dbContext)
	{
	}
}
