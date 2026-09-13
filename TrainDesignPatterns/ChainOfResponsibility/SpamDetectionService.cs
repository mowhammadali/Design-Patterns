namespace TrainDesignPatterns.ChainOfResponsibility;

public class SpamDetectionService
{
    private readonly SpamHandler _chain;

    public SpamDetectionService()
    {
        _chain = new KeyWordHandler();
        var blackListHandler = new BlackListHandler();

        _chain.SetSuccessor(blackListHandler);
    }

    public bool CheckForSpam(Email email)
    {
        return _chain.HandleSpamCheck(email);
    }
}