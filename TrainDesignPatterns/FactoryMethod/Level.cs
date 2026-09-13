namespace TrainDesignPatterns.FactoryMethod;

public abstract class Level
{
    public abstract IEnemy CreateEnemy();

    public void EncounterEnemy()
    {
        IEnemy enemy = CreateEnemy();
        enemy.Scare();
        enemy.Attack();
    }
}