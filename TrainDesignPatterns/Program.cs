using TrainDesignPatterns.AbstractFactory.CaveLevel;
using TrainDesignPatterns.AbstractFactory.Common;
using TrainDesignPatterns.Adapter;
using TrainDesignPatterns.Builder.Classic;
using TrainDesignPatterns.ChainOfResponsibility;
using TrainDesignPatterns.Decorator;
using TrainDesignPatterns.FactoryMethod;
using TrainDesignPatterns.Mediator;
using TrainDesignPatterns.Observer;
using TrainDesignPatterns.ShoppingCart;
using IEnemy = TrainDesignPatterns.AbstractFactory.Common.IEnemy;
using TrainDesignPatterns.Builder.Nested;
using TrainDesignPatterns.Builder.Fluent;
using Product = TrainDesignPatterns.Builder.Fluent.Product;


class Program
{
    static void Main(string[] args)
    {
        var builder = new Product.Builder().SetName("This is product name")
            .SetDescription("This is product description").Build();
    }
}