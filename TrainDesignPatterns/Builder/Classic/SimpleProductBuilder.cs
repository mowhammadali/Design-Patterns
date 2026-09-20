namespace TrainDesignPatterns.Builder.Classic;

public class SimpleProductBuilder : IBuilder
{
    private string _productName = "";
    private string _productDescription = "";
    
    public void BuildName()
    {
        _productName = "This is simple product name";
    }

    public void BuildDescription()
    {
        _productDescription = "This is simple product description";
    }

    public Product Build()
    {
        return new Product(_productName, _productDescription);
    }
}