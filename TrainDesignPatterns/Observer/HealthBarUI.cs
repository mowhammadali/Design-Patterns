namespace TrainDesignPatterns.Observer;

public class HealthBarUI : IGameObserver
{
    private readonly Player _subject;

    public HealthBarUI(Player subject)
    {
        _subject = subject;
    }

    public void Update()
    {
        var health = _subject.GetHealth();

        Console.WriteLine("Health: " + health);

        if (health == 0)
        {
            Console.WriteLine("You game over");
        }
    }
}