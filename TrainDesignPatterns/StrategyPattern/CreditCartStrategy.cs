namespace TrainDesignPatterns.ShoppingCart;

public class CreditCartStrategy(string cardNumber, string cvv, string expirationDate) : IPayment
{
    private string CardNumber { get; set; } = cardNumber;
    private string Cvv { get; set; } = cvv;
    private string ExpirationDate { get; set; } = expirationDate;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} Pay with credit card");
    }
}