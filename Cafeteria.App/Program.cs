using System;
using Cafeteria;

class Program
{
    static void Main(string[] args)
    {
        var facade = new CafeteriaFacade();

        facade.MakeSimpleCoffee();
        facade.DeliverOrder("default");
        facade.FinishOrder();

        var config = GlobalConfiguration.getInstance();
        config.addObserver(new Clients("João"));

        config.SetNewIngredient("Baunilha");
    }
}