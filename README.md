# GlobalTicket - TicketManager

This solution exemplifies the correct application of Clean Architecture principles.

The Application layer leverages the MediatR library to ensure a clear separation of concerns between commands/queries and the API project.

Commands and queries, in turn, invoke methods defined by interfaces located in the Certificate folder to perform persistence operations. These operations are abstracted as IAsyncRepository interfaces within the Application layer, while their concrete implementations reside in the Persistence project.

Each project adheres to the Dependency Injection paradigm by extending the IServiceCollection interface within each class library to fulfill its specific purpose. For example, validation classes are identified and registered dynamically through reflection, utilizing assembly filtering rules specified in the registration methods.

This project does not rely on any existing commercial solutions but is instead a conceptual design developed  just fruit of mine imagination.

![Image](./DamonReadMe.jpeg)
