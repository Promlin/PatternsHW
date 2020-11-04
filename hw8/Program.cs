using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using hw8;
using hw8.Controller;
using hw8.Model;

namespace hw8
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
            //Application.Run(new Form1());
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Form1 view = new Form1();
                IModel mdl = new IncrementModel();
                IController cnt = new IncrementController(view, mdl);
                Application.Run(view);

                //Application.Run(new Form1());
            }
        }
    }
}
