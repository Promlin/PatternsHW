using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.View
{
    public class ViewEventArgs : EventArgs
    {
        public string value;
        public ViewEventArgs(string v) => value = v;
    }
}
