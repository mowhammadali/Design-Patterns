namespace TrainDesignPatterns.Mediator;

public class RegularUser(string name) : User(name)
{
    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"User: {name} received: {message} from {senderName}");
    }

    public override void Send(string message)
    {
        Console.WriteLine($"User: {name} says: {message}");
        _mediator.Notify(this , message);
    }
}