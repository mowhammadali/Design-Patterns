namespace TrainDesignPatterns.ChainOfResponsibility;

public abstract class SpamHandler
{
    protected SpamHandler? _successor;
    
    public void SetSuccessor(SpamHandler spamHandler)
    {
        _successor = spamHandler;
    }

    public abstract bool HandleSpamCheck(Email email);
}