namespace GlobalTicket.TicketManagement.Application.Models.Mail;

public class Email
{
	public string To      { get; set; }
	public string Subject { get; set; }
	public string Body    { get; set; }
}

public class EmailSettings
{
	public string ApiKey      { get; set; } = string.Empty;
	public string FromAdress  { get; set; } = string.Empty;
	public string DisplayName { get; set; } = string.Empty;
}