namespace TrainDesignPatterns.Adapter;

public class LegacyRectangleAdapter(LegacyRectangle legacyRectangle) : IRectangle
{
    public long GetArea()
    {
        return legacyRectangle.CalculateArea();
    }
}