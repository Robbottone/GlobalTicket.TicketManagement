using Application.Contracts.Infrastructure;
using AutoMapper;
using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using GlobalTicket.TicketManagement.Application.Features.EventGig.Queries.EventGigList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EventGig.Queries.EventExport;

public class EventExportRequestHandler : IRequestHandler<EventExportRequest, EventExportFileVM>
{
	private readonly IEventGigRepostiory eventRepository;
	private readonly IMapper mapper;
	private readonly ICsvExporter csvExporter;

	public EventExportRequestHandler(IEventGigRepostiory eventGigRepository, IMapper mapper, ICsvExporter csvExporter)
	{
		this.eventRepository = eventGigRepository;
		this.mapper = mapper;
		this.csvExporter = csvExporter;
	}

	public async Task<EventExportFileVM> Handle(EventExportRequest request, CancellationToken cancellationToken)
	{
		var allEventGigs = this.mapper.Map<List<EventGigViewModel>>((await eventRepository.ListAllAsync()).OrderBy(x => x.EventDate));

		var fileData = this.csvExporter.ExportEventsToCsv<EventGigViewModel>(allEventGigs);

		var eventExprotFileDto = new EventExportFileVM() {
			EventExportFileName = $"{Guid.NewGuid()}.csv",
			ContentType = "text/csv",
			Data = fileData
		};

		return eventExprotFileDto;
	}
}
