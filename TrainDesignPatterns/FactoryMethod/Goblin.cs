namespace TrainDesignPatterns.FactoryMethod;

public class Goblin : IEnemy
{
    public void Scare()
    {
        Console.WriteLine("Scared by goblin");
    }

    public void Attack()
    {
        Console.WriteLine("Attacked by goblin");
    }
}