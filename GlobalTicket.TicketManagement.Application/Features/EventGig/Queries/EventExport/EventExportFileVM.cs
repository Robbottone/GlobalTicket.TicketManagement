namespace Application.Features.EventGig.Queries.EventExport;

public class EventExportFileVM
{
	public string EventExportFileName { get; set; } = string.Empty;
	public string ContentType { get; set; } = string.Empty;
	public byte[]? Data { get; set; }
}
