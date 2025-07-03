using Microsoft.AspNetCore.Mvc; // Import the ASP.NET Core MVC namespace for controller functionality.
using fundamentals.Services; // Import the namespace containing the IMessageService interface.

namespace fundamentals.Controllers // Define a namespace to organize controller classes.
{
    [ApiController] // Attribute indicating that this class is an API controller, enabling automatic model validation and response formatting.
    [Route("[controller]")] // Attribute specifying the route template for this controller; the controller name will be used in the route.
    public class HomeController : ControllerBase // Define the HomeController class, inheriting from ControllerBase, which provides basic functionality for API controllers.
    {
        private readonly IMessageService _messageService; // Declare a private read-only field to hold the injected IMessageService instance.

        // Constructor that takes an IMessageService parameter and assigns it to the _messageService field.
        public HomeController(IMessageService messageService)
        {
            _messageService = messageService; // Assign the injected service to the field for use in the controller methods.
        }

        [HttpGet] // Attribute indicating that this method responds to HTTP GET requests.
        public IActionResult Get() // Define the Get method, which returns an IActionResult.
        {
            return Ok(_messageService.GetMessage()); // Call the GetMessage method on the injected service and return its result as an HTTP 200 OK response.
        }
    }
}