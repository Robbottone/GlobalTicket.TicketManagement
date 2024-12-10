namespace GlobalTicket.TicketManagement.Application.Contracts.Responses;

public class BaseResponse<T> where T: notnull
{
	public BaseResponse()
	{
		Success = true;
	}

	public BaseResponse(bool success, string message = null)
	{
		Success = success;
		Message = message;
	}

	public bool Success   { get; set; }
	public string Message { get; set; }	
	public T Data         { get; set; }

	public List<string>? ValidationErrors { get; set; }
}
