using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    class Program
    {
        private static Contestant contestant;

        static void Main(string[] args)
        {
            
            Sweepstakes sweepstakes = new Sweepstakes("k");
            sweepstakes.RegisterConstestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }
    }
}
