# GlobalTicket - TicketManager

This solution emulates the correct implementation of the Clean Architecture principles.
 
The application uses the MediatR library to guarantee the seperation between the commands/queries and the effective action performed within the Persistence project.
Every project uses the DipendencyInjection priciple, extending the IServiceCollection object with the class library wrapping different purpouse.
For example is able to individuate and registrate every Validation Class thorugh Reflection, fetching the assemblies respecting the filter rule set.

This project does not use any existing commercial application, is just fruit of mine imagination. 
