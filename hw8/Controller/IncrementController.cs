using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8;
using hw8.Model;
using hw8.View;

namespace hw8.Controller
{
    public class IncrementController : IController
    {
        IView view;
        IModel model;
        public IncrementController(IView v, IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.Attach((IModelObserver)view);
            view.Changed += new ViewHandler<IView>(this.ViewChanged);
        }
        public void ViewChanged(IView v, ViewEventArgs e) => model.SetValue(e.value);
        public void IncrementValue() => model.Increment();
    }
}
