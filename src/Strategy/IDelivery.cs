using System;

namespace Cafeteria
{
/// <summary>
/// Defines a strategy for calculating delivery cost.
/// </summary>

    public interface IDelivery
    {
        double Calculate();
        string GetType();
    }
}