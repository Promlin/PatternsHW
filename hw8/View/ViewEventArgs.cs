using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8.View
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public class ViewEventArgs : EventArgs
    {
        public int value;
        public ViewEventArgs(int v) => value = v;
    }
}
