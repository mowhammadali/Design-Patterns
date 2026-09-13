namespace TrainDesignPatterns.Observer;

public interface IGameSubject
{
    public void Attach(IGameObserver observer);
    public void Detach(IGameObserver observer);
    public void Notify();
    public int GetScore();
    public int GetHealth();
}