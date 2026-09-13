namespace TrainDesignPatterns.AbstractFactory.Common;

public abstract class LevelElementFactory
{
    public abstract IEnemy CreateEnemy();
    public abstract IWeapon CreateWeapon();
    public abstract IPowerUp CreatePowerUp();
}