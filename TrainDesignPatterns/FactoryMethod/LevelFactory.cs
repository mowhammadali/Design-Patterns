namespace TrainDesignPatterns.FactoryMethod;

public static class LevelFactory
{
    public static Level CreateLevel(int levelNumber)
    {
        return levelNumber switch
        {
            1 => new CaveLevel(),
            2 => new HuntedHouseLevel(),
            _ => throw new ArgumentOutOfRangeException(nameof(levelNumber), levelNumber, null)
        };
    }
}