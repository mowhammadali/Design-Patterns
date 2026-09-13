namespace TrainDesignPatterns.ShoppingCart;

public class PaypalStrategy(string email, string password) : IPayment
{
    private string Email { get; set; } = email;
    private string Password { get; set; } = password;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} Pay with paypal");
    }
}