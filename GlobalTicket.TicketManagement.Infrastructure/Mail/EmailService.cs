using GlobalTicket.TicketManagement.Application.Contracts.Infrastructure;
using GlobalTicket.TicketManagement.Application.Models.Mail;
using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace GlobalTicket.TicketManagement.Infrastructure.Mail;

   public class EmailService : IEmailService
   {
      public EmailSettings emailSettings { get; }

      public EmailService(IOptions<EmailSettings> mailSettings)
      {
         emailSettings = mailSettings.Value;
      }

      public async Task<bool> SendEmail(Email email)
      {
         var client = new SendGridClient(emailSettings.ApiKey);

         var subject = email.Subject;
         var to = new EmailAddress(email.To);
         var emailBody = email.Body;

         var from = new EmailAddress
         {
               Email = emailSettings.FromAdress,
               Name = emailSettings.DisplayName
         };

         var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);
         var response = await client.SendEmailAsync(sendGridMessage);

         if (response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK)
               return true;

         return false;
      }
   }
