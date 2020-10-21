using System;
using System.Threading;

namespace hw4
{
    //Оператор lock определяет блок кода, внутри которого весь код блокируется и становится недоступным
    //для других потоков до завершения работы текущего потока

    class Program
    {
        static void MainPrintMethod()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(20);
                Console.Write("Main i " + i);
            }
        }

        static void Main(string[] args)
        {
            MainPrintMethod();

            Console.WriteLine("Finish of 1 method's work");

            //Создание потока и вызов метода из класса Program
            ThreadStart currentTask = new ThreadStart(MainPrintMethod);
            var thread = new Thread(currentTask);
            thread.Start();

            //Получение статического метода из одиночки
            Singleton.printStringInSingleton();
            Console.WriteLine("Finish of Singleton's method work");  //Завершение работы метода из одиночки


            //Создание еще одного потока c методом из одиночки
            ThreadStart newTask = new ThreadStart(Singleton.printStringInSingleton);
            var thread2 = new Thread(newTask);
            thread2.Start();

        }
    }
}
