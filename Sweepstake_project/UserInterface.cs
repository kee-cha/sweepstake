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
            Console.WriteLine("Please enter your firstname.");
            return Console.ReadLine().ToLower();
        }

        public static string GetContestantLastName()
        {
            Console.WriteLine("Please enter your lastname.");
            return Console.ReadLine().ToLower();

        }

        public static string GetContestantEmail()
        {
            Console.WriteLine("Please enter your email address.");
            return Console.ReadLine().ToLower();
        }

        public static string GetRegistrationNumber()
        {
            Console.WriteLine("Please enter any positive integer for your registration number.");
            return Console.ReadLine();
            
        }

    }
}
