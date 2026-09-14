namespace TrainDesignPatterns.Mediator;

public class AdminUser(string name) : User(name)
{
    public override void Receive(string message, string senderName)
    {
        Console.WriteLine($"Admin: {name} received: {message} from {senderName}");
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Admin: {name} says: {message}");
        _mediator.Notify(this, message);
    }
}