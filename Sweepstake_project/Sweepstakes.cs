using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    public class Sweepstakes
    {

        Dictionary<int, Contestant> dictionaryOfContestants;

        public Sweepstakes(string name)
        {

            dictionaryOfContestants = new Dictionary<int, Contestant>();
        }

        public void RegisterConstestant(Contestant contestant)
        {
            contestant = new Contestant();
            contestant.registrationNum = dictionaryOfContestants.Count + 1;
            dictionaryOfContestants.Add(contestant.registrationNum, contestant);
        }

        public string PickWinner()
        {
            Contestant contestant;
            Random random = new Random();
            int winner = random.Next(dictionaryOfContestants.Count) + 1; //found key from dictionary
            contestant = dictionaryOfContestants[winner]; // find value pair to key with []
            return contestant.FirstName + " " + contestant.LastName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayWinner(contestant);
        }
    }
}
