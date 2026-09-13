namespace TrainDesignPatterns.FactoryMethod;

public class Ghost : IEnemy
{
    public void Scare()
    {
        Console.WriteLine("Scared by ghost");
    }

    public void Attack()
    {
        Console.WriteLine("Scared by ghost");
    }
}