using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> dictionaryOfContestants;


        public Sweepstakes()
        {
            dictionaryOfContestants = new Dictionary<int, Contestant>();
        }

        public void RegisterConstestant(Contestant contestant)
        {
            contestant.registrationNum = dictionaryOfContestants.Count + 1;
            dictionaryOfContestants.Add(contestant.registrationNum, contestant);
        }
        public string PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(dictionaryOfContestants.Count); //found key from dictionary
            Contestant custWin = dictionaryOfContestants[winner]; // find value pair to key with []
            return custWin.FirstName + " " + custWin.LastName;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            string info = contestant.FirstName + "\n" +
                          contestant.LastName + "\n" +
                          contestant.Email + "\n";
            Console.WriteLine(info);
            Console.ReadLine();
        }

    }
}
