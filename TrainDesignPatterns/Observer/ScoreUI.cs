namespace TrainDesignPatterns.Observer;

public class ScoreUI : IGameObserver
{
    private readonly Player _subject;

    public ScoreUI(Player subject)
    {
        _subject = subject;
    }

    public void Update()
    {
        var score = _subject.GetScore();

        Console.WriteLine($"Score: {score}");
    }
}