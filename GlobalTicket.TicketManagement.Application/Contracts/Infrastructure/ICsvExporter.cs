namespace Application.Contracts.Infrastructure
{
	public interface ICsvExporter
	{
		byte[] ExportEventsToCsv<T>(List<T> records);
	}
}
