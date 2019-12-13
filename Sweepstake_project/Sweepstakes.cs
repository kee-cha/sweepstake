using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    public class Sweepstakes
    {
        
        string name;
        Dictionary<int, Contestant> dictionaryOfContestants;

        public Sweepstakes(string name)
        {
            this.name = name;
            dictionaryOfContestants = new Dictionary<int, Contestant>();
        }

        public void RegisterConstestant( Contestant contestant)
        {
            contestant.registrationNum = dictionaryOfContestants.Count + 1;
            dictionaryOfContestants.Add(contestant.registrationNum, contestant);
        }

        public string PickWinner()
        {
            Contestant contestant;
            Random random = new Random();
            contestant = dictionaryOfContestants[(random.Next(dictionaryOfContestants.Count + 1))]; 
            return contestant.FirstName + " " + contestant.LastName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {   
            UserInterface.DisplayWinner(contestant);
        }
    }
}
