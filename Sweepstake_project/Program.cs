using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetSweepstakeName());
            Contestant contestant = new Contestant();            
            sweepstakes.RegisterConstestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }
    }
}
