namespace TrainDesignPatterns.Decorator;

public class CaramelDecorator : CoffeeDecorator
{
    public CaramelDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 30;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} , +Caramel";
    }
}