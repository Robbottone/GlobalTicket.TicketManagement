using Application.Contracts.Infrastructure;
using CsvHelper;
using System.Globalization;

namespace Infrastructure.CsvExporter;

public class CsvExport : ICsvExporter
{
	public byte[] ExportEventsToCsv<T>(List<T> records)
	{
		using var memoryStream = new MemoryStream();
		using (var streamWriter = new StreamWriter(memoryStream))
		{
			using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
			csvWriter.WriteRecords(records);
		}

		return memoryStream.ToArray();
	}
}
