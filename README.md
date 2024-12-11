# GlobalTicket - TicketManager

This solution emulates the correct implementation of the Clean Architecture principles.
 
The application uses the MediatR library to guarantee the seperation between the commands/queries and the API project. 

The commands and query will in turn call the methods exposed by the interfaces formulated into the Certificate folder in order to execute the persistance operations.
Every persisting operation is represented in Applicaiton as IAsyncRepository, meanwhile its implementation is performed inside the persistence project. 

Every project uses the DipendencyInjection metodology, extending the IServiceCollection interface for every class library purpouse.
For example is able to individuate and registrate every Validation Class thorugh Reflection, fetching the assemblies respecting the filter rule set into the Registration methods.

This project does not use any existing commercial application, is just fruit of mine imagination. 

![Image](./DamonReadMe.jpeg){ width="800" height="600" style="display: block; margin: 0 auto" }
