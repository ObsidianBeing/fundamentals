namespace fundamentals.Services // Define a namespace to organize related classes and interfaces.
{
    public class HelloMessageService : IMessageService // Declare a class named HelloMessageService that implements the IMessageService interface.
    {
        // Implement the GetMessage method defined in the IMessageService interface.
        public string GetMessage()
        {
            return "Hello from DI!"; // Return a greeting message as a string.
        }
    }
}