namespace TrainDesignPatterns.Decorator;

public class Coffee : ICoffee
{
    public decimal GetPrice()
    {
        return 100m;
    }

    public string GetDescription()
    {
        return "Coffee";
    }
}