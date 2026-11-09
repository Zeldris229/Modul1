using DeliveryService.Interfaces;
using DeliveryService.Models;
using DeliveryService.Payments;
using DeliveryService.Services;
using System;
namespace DeliveryService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryService.Services.DeliveryService service =
            new DeliveryService.Services.DeliveryService();
            Car car = new Car();
            service.AddTransport(car);
            Truck truck = new Truck();
            service.AddTransport(truck);
            Bike bike = new Bike();
            service.AddTransport(bike);

            Order order1 = new Order(1, "Косметика", 2, 7);
            service.AddOrder(order1);
            Order order2 = new Order(2, "Техніка", 93, 9);
            service.AddOrder(order2);
            Order order3 = new Order (3, "Продукти", 4, 6);
            service.AddOrder(order3);
            Order order4 = new Order(4, "Продукти", 6, 18);
            service.AddOrder(order4);

            Console.WriteLine("Вартість Доставки: ");

            service.ShowDeliveryCosts(order1);
            service.ShowDeliveryCosts(order2);
            service.ShowDeliveryCosts(order3);
            service.ShowDeliveryCosts(order4);

            Console.WriteLine("\nПризначення Транспорту: ");
            bool result1 = service.AssignTransport(order1, bike);
            if (result1)
                Console.WriteLine("Для замовлення 1 призначено: Велосипед ");
            else
                Console.WriteLine("Не вдалося призначити Велосипед");

            bool result2 = service.AssignTransport(order2, truck);
            if (result2)
                Console.WriteLine("Для замовлення 2 призначено:Вантажівку  ");
            else
                Console.WriteLine("Не вдалося призначити Вантажівку");

            bool result3 = service.AssignTransport(order3, bike);
            if (result3)
                Console.WriteLine("Для замовлення 3 призначено: Велосипед ");
            else
                Console.WriteLine("Не вдалося призначити Велосипед");

            bool result4 = service.AssignTransport(order4, car);
            if (result4)
                Console.WriteLine("Для замовлення 4 призначено: Автомобіль ");
            else
                Console.WriteLine("Не вдалося призначити Автомобіль");


            Console.WriteLine("\nЗавершення Доставки: ");


            CashPayment cash = new CashPayment();
            CardPayment card = new CardPayment();

            bool delivery1 = service.CompleteDelivery(order1, card);
            if (delivery1)
                Console.WriteLine("Замовлення 1 доставлено!");
            else
                Console.WriteLine("Не вдалося завершити замовлення 1");

            bool delivery2 = service.CompleteDelivery(order2, cash);
            if (delivery2)
                Console.WriteLine("Замовлення 2 доставлено!");
            else
                Console.WriteLine("Не вдалося завершити замовлення 2");

            bool delivery3 = service.CompleteDelivery(order3, cash);
            if (delivery3)
                Console.WriteLine("Замовлення 3 доставлено!");
            else
               Console.WriteLine("Не вдалося завершити замовлення 3");

           /* bool delivery4 = service.CompleteDelivery(order4, cash);
            if (delivery4)
                Console.WriteLine("Замовлення 4 доставлено!");
            else
                Console.WriteLine("Не вдалося завершити замовлення 4");*/
            service.ShowOrders();
            service.ShowHistory();

        }
    }
}