using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    class Sweepstakes
    {
        Dictionary<string, Contestant> dictionary;

        public Sweepstakes(string name)
        {
           dictionary = new Dictionary<string, Contestant>();
        }

        public void RegisterConstestant(Contestant contestant)
        {
            contestant = new Contestant();
            dictionary.Add(contestant.RegistrationNum,contestant);
        }
        public string PickWinner()
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
