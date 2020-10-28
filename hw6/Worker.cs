using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    public abstract class Worker
    {
        protected WorkerLevel level;
        protected Worker nextWorker;
        public void SetNextWorker(Worker nextWorker) => this.nextWorker = nextWorker;
        public void WorkerInfo(WorkerLevel level, string message)
        {
            if (this.level <= level) Write(message);
            if (nextWorker != null) nextWorker.WorkerInfo(level, message);
        }

        abstract protected void Write(string message);
    }
}
