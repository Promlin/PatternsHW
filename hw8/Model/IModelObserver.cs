using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8.Model
{
    public interface IModelObserver
    {
        void ValueIncremented(IModel model, ModelEventArgs e);
    }
}
