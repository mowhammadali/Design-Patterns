using TrainDesignPatterns.AbstractFactory.Common;

namespace TrainDesignPatterns.AbstractFactory.HuntedHouseLevel;

public class HuntedHouseLevelFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }

    public override IWeapon CreateWeapon()
    {
        return new Staff();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Orb();
    }
}