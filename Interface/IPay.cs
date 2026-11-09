using System;
using System.Collections.Generic;
using System.Text;
namespace DeliveryService.Interfaces
{
    public interface IPay
    {
        bool Pay(double amount);
    }
}
