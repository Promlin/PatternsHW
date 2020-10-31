using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    public class UsualWorker : Worker
    {
        public UsualWorker(WorkerLevel level) => this.level = level;
        protected override void Write(string message)
        {
            Console.WriteLine("UsualWorker: Недостаточно полномочий для получения нужной суммы");
        }
    }

    public class WorkersBoss :Worker
    {
        public WorkersBoss(WorkerLevel level) => this.level = level;
        protected override void Write(string message)
        {
            Console.WriteLine("WorkersBoss: Недостаточно полномочий для получения нужной суммы");
        }
    }

    public class Director : Worker
    {
        public Director(WorkerLevel level) => this.level = level;
        protected override void Write(string message)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10);
            if(randomNumber < 5.1) { Console.WriteLine("Director: Получите нужную сумму в бухгалтерии"); }
            else { Console.WriteLine("Director: Вам только кажется, что нужны деньги. Можно обойтись и без них"); }
        }
    }
}
