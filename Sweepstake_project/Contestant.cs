using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstake_project
{
    public class Contestant
    {
        string firstName;
        string lastName;
        string email;
        string registrationNum;

        public string RegistrationNum { get { return registrationNum; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; }}
        public string Email { get { return email; } }

        public Contestant()
        {
         firstName = UserInterface.GetContestantFirstName();
         lastName = UserInterface.GetContestantLastName();
         email = UserInterface.GetContestantEmail();
         registrationNum = UserInterface.GetRegistrationNumber();
        }

    }
}
