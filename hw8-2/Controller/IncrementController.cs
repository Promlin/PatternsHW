using hw8_2.Model;
using hw8_2.View;


namespace hw8_2.Controller
{
    public class IncrementController : IController
    {
        IView view;
        IModel model;
        private ActiveMVCForm view1;
        private IModel mdl;

        public IncrementController(IView v, IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.Attach((IModelObserver)view);
            view.AddString += new ViewHandler<IView>(this.ViewChanged);
        }

        public IncrementController(ActiveMVCForm view1, IModel mdl)
        {
            this.view1 = view1;
            this.mdl = mdl;
        }

        public void AddListToListBox()
        {
            throw new System.NotImplementedException();
        }

        public void ViewChanged(IView v, ViewEventArgs e) => model.AddString(e.value);

    }
}
