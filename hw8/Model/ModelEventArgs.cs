using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8.Model
{
    public class ModelEventArgs : EventArgs
    {
        public int newval;
        public ModelEventArgs(int v) => newval = v;
    }
}
