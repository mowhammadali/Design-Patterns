namespace TrainDesignPatterns.ShoppingCart;

public class ShoppingCart
{
    private IPayment _strategyPayment;

    public void SetStrategy(IPayment strategy)
    {
        _strategyPayment = strategy;
    }

    public void Checkout(decimal amount)
    {
        _strategyPayment.Pay(amount);
    }
}