using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPatterns.Controller;

namespace hw8.View
{
    public interface IView
    {
        event ViewHandler<IView> Changed;
        void SetController(IController cont);
    }
}
