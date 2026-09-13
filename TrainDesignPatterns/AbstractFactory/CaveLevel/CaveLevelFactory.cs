using TrainDesignPatterns.AbstractFactory.Common;

namespace TrainDesignPatterns.AbstractFactory.CaveLevel;

public class CaveLevelFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }

    public override IWeapon CreateWeapon()
    {
        return new Axe();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Crystal();
    }
}