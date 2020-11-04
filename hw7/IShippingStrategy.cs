using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}
