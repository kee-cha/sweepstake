using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    public static class SweepstakeManagerFactory
    {
        public static ISweepstakesManager ChooseManager()
        {
            ISweepstakesManager choice;
            string input = (UserInterface.PickSweepstakeManager());
            switch (input)
            {
                case "1":
                    choice = new SweepstakesStackManager();
                    return choice;
                case "2":
                    choice = new SweepstakesQueueManager();
                    return choice;
                default:
                    throw new ApplicationException("Invalid choice");                    
            }
        }
    }
}
