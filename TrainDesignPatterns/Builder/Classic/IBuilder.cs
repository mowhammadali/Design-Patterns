namespace TrainDesignPatterns.Builder.Classic;

public interface IBuilder
{
    void BuildName();
    void BuildDescription();
    Product Build();
}