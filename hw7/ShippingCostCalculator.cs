using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    public class ShippingCostCalculator : IShippingStrategy
    {
        //public double Calculate(Order order, Func<Order, double> shippingCostStrategy)
        //{
        //    return shippingCostStrategy(order);
        //}

        public double Calculate(Order order)
        {
            return 100; //рассчет стоимости доставки
        }
    }
}
