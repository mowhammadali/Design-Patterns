namespace TrainDesignPatterns.ChainOfResponsibility;

public class KeyWordHandler : SpamHandler
{
    public override bool HandleSpamCheck(Email email)
    {
        Console.WriteLine("Checking for keyword spam check");
        
        if (ContainsSpamKeyWord(email.body) || ContainsSpamKeyWord(email.subject))
        {
            Console.WriteLine("keyword spam detected");
            return true;
        }

        if (_successor is null)
        {
            return false;
        }

        return _successor.HandleSpamCheck(email);
    }

    private static bool ContainsSpamKeyWord(string text)
    {
        return (text.ToLower().Contains("prince"));
    }
}