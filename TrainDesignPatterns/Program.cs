using TrainDesignPatterns.AbstractFactory.CaveLevel;
using TrainDesignPatterns.AbstractFactory.Common;
using TrainDesignPatterns.Adapter;
using TrainDesignPatterns.ChainOfResponsibility;
using TrainDesignPatterns.Decorator;
using TrainDesignPatterns.FactoryMethod;
using TrainDesignPatterns.Mediator;
using TrainDesignPatterns.Observer;
using TrainDesignPatterns.ShoppingCart;
using IEnemy = TrainDesignPatterns.AbstractFactory.Common.IEnemy;


class Program
{
    static void Main(string[] args)
    {
        ChatRoom chatRoom = new ChatRoom();

        RegularUser Ivan = new RegularUser("Ivan");
        RegularUser John = new RegularUser("John");
        AdminUser Alex = new AdminUser("Alex");

        chatRoom.AddUser(Ivan, John, Alex);

        Ivan.Send("Hello everyone!");
        John.Send("Hello Ivan, How are you?");
        Ivan.Send("I'm fine");

        Alex.Send("Keep it friendly guys!");
    }
}