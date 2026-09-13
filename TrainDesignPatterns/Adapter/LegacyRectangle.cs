namespace TrainDesignPatterns.Adapter;

public class LegacyRectangle(int left, int top, int right, int bottom)
{
    public int CalculateArea()
    {
        return (bottom - top) * (right - left);
    }
}