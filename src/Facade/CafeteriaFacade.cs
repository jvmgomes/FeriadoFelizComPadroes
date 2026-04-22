using System;

namespace Cafeteria
{
/// <summary>
/// Provides a simplified interface to the cafeteria system,
/// coordinating drink creation, delivery calculation, and order finalization.
/// </summary>
    public class CafeteriaFacade
    {
        private IDrinks? currentDrink;
        private IDelivery? delivery;

        public void MakeSimpleCoffee()
        {
            currentDrink = new Expresso();
            Console.WriteLine("Café Simples Criado.");
        }
        // adicionar mais drinks

        public void DeliverOrder(string type)
        {
            if (currentDrink == null)
            {
                Console.WriteLine("Você precisa escolher uma bebida.");
                return;
            }
            
            switch(type)
            {
                case "default":
                    delivery = new DefaultOrder();
                    break;

                case "express":
                    delivery = new ExpressDelivery();
                    break;

                case "pickup":
                    delivery = new PickupDelivery();
                    break;

                default:
                    Console.WriteLine("Tipo inválido");
                    return;
            }

            double cost = delivery.Calculate();

            Console.WriteLine(delivery.GetDeliveryType());
            Console.WriteLine("Custo entrega: " + cost);
        }

        public void FinishOrder()
        {
            if (currentDrink == null)
            {
                Console.WriteLine("Você precisa escolher uma bebida.");
                return;
            }
            if (delivery == null)
            {
                Console.WriteLine("Você precisa escolher um tipo de entrega.");
                return;
            
            }
            
            Console.WriteLine("Pedidio finalizado");

            Console.WriteLine(currentDrink.getDescricao());

            INotification whatsapp = NotificationFactory.Create("whatsapp");
            whatsapp.send("Seu pedido saiu para entrega!");

        
        }
    }
}