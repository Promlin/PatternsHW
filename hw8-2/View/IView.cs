using hw8_2.Controller;

namespace hw8_2.View
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
    public interface IView
    {
        event ViewHandler<IView> AddString;
        void SetController(IController cont);
        void SetController(IncrementController incrementController);
    }
}
