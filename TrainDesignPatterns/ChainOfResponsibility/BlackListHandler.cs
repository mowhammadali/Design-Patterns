namespace TrainDesignPatterns.ChainOfResponsibility;

public class BlackListHandler : SpamHandler
{
    public override bool HandleSpamCheck(Email email)
    {
        Console.WriteLine("Checking for black list spam check");

        if (CheckBlackList(email.sender))
        {
            Console.WriteLine("black list spam detected");
            return true;
        }

        if (_successor is null)
        {
            Console.WriteLine("No spam detected");
            
            return false;
        }

        return _successor.HandleSpamCheck(email);
    }

    private static bool CheckBlackList(string sender)
    {
        return (sender.ToLower().Contains("spam"));
    }
}