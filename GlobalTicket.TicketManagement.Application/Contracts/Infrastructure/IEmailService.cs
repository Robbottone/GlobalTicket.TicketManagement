﻿using GlobalTicket.TicketManagement.Application.Models.Mail;

namespace GlobalTicket.TicketManagement.Application.Contracts.Infrastructure;

public interface IEmailService
{
	Task<bool> SendEmail(Email email);
}
