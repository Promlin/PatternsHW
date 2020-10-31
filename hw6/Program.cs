using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    class Program
    {
        private static Worker GetChainOfWorkers()
        {
            Director director = new Director(WorkerLevel.Director);
            WorkersBoss workersBoss = new WorkersBoss(WorkerLevel.WorkersBoss);
            UsualWorker usualWorker = new UsualWorker(WorkerLevel.UsualWorker);

            usualWorker.SetNextWorker(workersBoss);
            workersBoss.SetNextWorker(director);
            return director;
        }
        static void Main(string[] args)
        {
            Worker worker = GetChainOfWorkers();

            worker.WorkerInfo(WorkerLevel.UsualWorker, "Обычный рабочий");
            Console.WriteLine();

            worker.WorkerInfo(WorkerLevel.WorkersBoss, "Начальник отдела");
            Console.WriteLine();

            worker.WorkerInfo(WorkerLevel.Director, "Директор");
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
