namespace fundamentals.Services // Define a namespace to organize related classes and interfaces.
{
    public interface IMessageService // Declare an interface named IMessageService that will define a contract for message services.
    {
        string GetMessage(); // Define a method signature for GetMessage that returns a string. 
                             // Any class implementing this interface must provide an implementation for this method.
    }
}