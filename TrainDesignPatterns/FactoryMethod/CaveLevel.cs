namespace TrainDesignPatterns.FactoryMethod;

public class CaveLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }
}