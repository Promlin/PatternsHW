using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Order, double> emsStrategy = (Order order) => { return 3; };
            Func<Order, double> upsStrategy = (Order order) => { return 4; };
            Func<Order, double> fedexStrategy = (Order order) => { return 5; };

            Order e = new Order();

            ShippingCostCalculator shippingCostCalculator = new ShippingCostCalculator();
            //var result = shippingCostCalculator.Calculate(e, emsStrategy);
            var result = shippingCostCalculator.Calculate(e);
            Console.WriteLine(result);
        }
    }
}
