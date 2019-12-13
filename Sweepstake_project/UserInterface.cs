using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    public static class UserInterface
    {
        public static string GetContestantFirstName()
        {
            Console.WriteLine("Please enter firstname.");
            return Console.ReadLine().ToLower();            
        }

        public static string GetContestantLastName()
        {
            Console.WriteLine("Please enter lastname.");
            return Console.ReadLine().ToLower();            
        }

        public static string GetContestantEmail()
        {
            Console.WriteLine("Please enter email address.");            
            return Console.ReadLine().ToLower();
        }

        public static string DisplayWinner(Contestant contestant)
        {
            Console.WriteLine("Firstname: " + contestant.FirstName + "\n" +
              "Lastname: " + contestant.LastName + "\n" +
              "Email address: " + contestant.Email + "\n" +
              "Registration Number: " + contestant.registrationNum);            
            return Console.ReadLine();
        }

        public static string GetSweepstakeName()
        {
            Console.WriteLine("Enter name of sweepstake");            
            return Console.ReadLine();
        }
        public static string PickSweepstakeManager()
        {
            Console.WriteLine("Choose between 1- stack manager or 2- queue manager");
            return Console.ReadLine();
        }
    }
}
