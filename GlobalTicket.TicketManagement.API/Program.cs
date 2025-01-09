using GlobalTicket.TicketManagement.API;

var builder = WebApplication.CreateBuilder(args);
var app = builder.ConfigureService().ConfigurePipelines();
//await app.ResetDatabaseAsync();
app.Run();
