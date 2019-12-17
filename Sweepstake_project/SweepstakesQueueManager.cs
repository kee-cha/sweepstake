using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    class SweepstakesQueueManager: ISweepstakesManager
    {
        
        Queue<Sweepstakes> queue;
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = queue.Dequeue();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
