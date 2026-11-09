using System;
using System;
using System.Collections.Generic;
using System.Text;
using DeliveryService.Interfaces;
namespace DeliveryService.Payments
{
    public class CardPayment : IPay
    {
        public bool Pay(double amount)
        {
            if (amount <= 0)
                return false;

            Console.WriteLine($"Оплата карткою: {amount} грн");
            return true;
        }
    }
}
