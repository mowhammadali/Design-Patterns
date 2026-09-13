namespace TrainDesignPatterns.Observer;

public class Player : IGameSubject
{
    private readonly List<IGameObserver> _observers = new List<IGameObserver>();
    private int Health { get; set; }
    private int Score { get; set; }

    public void SetState(int health, int score)
    {
        Health = health;
        Score = score;
        Notify();
    }

    public int GetHealth() => Health;
    public int GetScore() => Score;

    public void Attach(IGameObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IGameObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}