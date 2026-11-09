using System;
using System.Collections.Generic;
using System.Text;
namespace DeliveryService.Models
{
    public class Car : Transport
    {
        public Car() : base("Автомобіль")
        {
        }

        public override double CalculateCost(Order order)
        {
            return 50 + 8 * order.Distance + 1 * order.Weight;
        }

        public override bool CanTake(Order order)
        {
            if (!base.CanTake(order))
                return false;

            if (order.Weight > 70)
                return false;

            return true;
        }
    }
}