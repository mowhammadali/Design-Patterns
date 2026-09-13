namespace TrainDesignPatterns.FactoryMethod;

public class HuntedHouseLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }
}