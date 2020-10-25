using System;
using System.Threading;

namespace hw4
{
    //Оператор lock определяет блок кода, внутри которого весь код блокируется и становится недоступным
    //для других потоков до завершения работы текущего потока

    class Program
    {
        static int x = 0;
        static object locker = new object();

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


            Console.ReadLine();
        }

        //Оператор lock 
        public static void Count()
        {
            lock (locker)
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
