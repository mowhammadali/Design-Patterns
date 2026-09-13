namespace TrainDesignPatterns.Decorator;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual decimal GetPrice()
    {
        return _coffee.GetPrice();
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
}