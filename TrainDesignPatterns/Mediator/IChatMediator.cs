namespace TrainDesignPatterns.Mediator;

public interface IChatMediator
{
    public void Notify(User sender, string @event);
}