using fundamentals.Services; // Import the namespace containing the IMessageService and HelloMessageService.

var builder = WebApplication.CreateBuilder(args); // Create a new instance of a WebApplicationBuilder, initializing it with command-line arguments.


// Register services with different lifetimes (choose one)
builder.Services.AddScoped<IMessageService, HelloMessageService>(); // Register IMessageService with a scoped lifetime, meaning a new instance is created per request.
// builder.Services.AddSingleton<IMessageService, HelloMessageService>(); // (Optional) Register IMessageService as a singleton, sharing a single instance across all requests.
// builder.Services.AddTransient<IMessageService, HelloMessageService>(); // (Optional) Register IMessageService with a transient lifetime, creating a new instance each time it is requested.

builder.Services.AddControllers(); // Add support for MVC controllers, enabling routing and model binding for API endpoints.

var app = builder.Build(); // Build the application pipeline based on the configured services.

app.MapControllers(); // Map attribute-routed API controllers to the application, allowing them to handle incoming HTTP requests.

app.Run(); // Run the application, starting the web server and listening for incoming requests.