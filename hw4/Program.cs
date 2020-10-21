using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            MainPrintMethod();

            Console.WriteLine("Finish of 1 method's work");

            //Создание потока и вызов метода из класса Program
            ThreadStart currentTask = new ThreadStart(MainPrintMethod);
            var thread = new Thread(currentTask);
            thread.Start();

        }

        static void MainPrintMethod()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(20);
                Console.Write("Main i " + i);
            }
        }
    }
}
