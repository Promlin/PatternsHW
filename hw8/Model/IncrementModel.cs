using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8.Model
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class IncrementModel : IModel
    {
        public event ModelHandler<IncrementModel> Changed;

        int value;

        public IncrementModel() => value = 0;

        public void SetValue(int v) => value = v;

        public void Increment()
        {
            value++;
            Changed.Invoke(this, new ModelEventArgs(value));
        }

        public void Attach(IModelObserver imo) =>
            Changed += new ModelHandler<IncrementModel>(imo.ValueIncremented);
    }
}
