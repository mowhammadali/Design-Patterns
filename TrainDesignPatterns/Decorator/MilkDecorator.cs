namespace TrainDesignPatterns.Decorator;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 15;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} , +Milk";
    }
}