namespace TrainDesignPatterns.Mediator;

public abstract class User(string name)
{
    public string Name { get; protected set; } = name;
    protected IChatMediator _mediator;

    public void SetMediator(IChatMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Receive(string message , string senderName);
    public abstract void Send(string message);
}