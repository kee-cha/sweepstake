using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    class SweepstakesStackManager: ISweepstakesManager
    {
        Sweepstakes sweepstakes = new Sweepstakes(name);
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = stack.Pop();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
