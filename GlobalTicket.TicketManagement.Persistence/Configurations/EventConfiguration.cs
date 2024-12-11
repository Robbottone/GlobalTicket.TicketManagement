using GlobalTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Persistence.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<EventGig>
{
	public void Configure(EntityTypeBuilder<EventGig> builder)
	{
		builder.Property(e => e.Name)
			.IsRequired()
			.HasMaxLength(50);
	}
}
