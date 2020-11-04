using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.Model
{
    public class ListModel : IModel
    {
        public event ModelHandler<ListModel> Changed;
        List<string> value;
        public ListModel() => value = new List<string>();
        public void AddString(string v)
        {
            value.Add(v);
            Changed.Invoke(this, new ModelEventArgs(v));
        }
        public void Attach(IModelObserver imo) => Changed += new ModelHandler<ListModel>(imo.ListChanged);
    }
}
