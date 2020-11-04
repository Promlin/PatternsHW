using hw8_2.Controller;
using hw8_2.Model;
using System;
using System.Windows.Forms;

namespace hw8_2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ActiveMVCForm());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ActiveMVCForm view = new ActiveMVCForm();
            IModel mdl = new ListModel();
            IController cnt = new IncrementController(view, mdl);
            Application.Run(view);
        }
    }
}
