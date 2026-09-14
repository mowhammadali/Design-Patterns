namespace TrainDesignPatterns.Mediator;

public class ChatRoom : IChatMediator
{
    private readonly List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
        user.SetMediator(this);
    }

    public void AddUser(params User[] users)
    {
        foreach (var user in users)
        {
            AddUser(user);
        }
    }

    public void Notify(User sender, string @event)
    {
        foreach (var user in _users)
        {
            if (user.Name != sender.Name)
            {
                user.Receive(@event, sender.Name);
            }
        }
    }
}