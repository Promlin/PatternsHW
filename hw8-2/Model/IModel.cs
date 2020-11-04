using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.Model
{
    public interface IModel
    {
        void Attach(IModelObserver imo);
        void AddString(string v);
    }
}
