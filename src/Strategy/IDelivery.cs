using System;

namespace Cafeteria
{
    public interface IDelivery
    {
        double Calculate();
        string GetType();
    }
}