using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstake_project
{
    public class Sweepstakes
    {        
        string name;
        Contestant winner;
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
           
            Random random = new Random();
            winner = dictionaryOfContestants[(random.Next(dictionaryOfContestants.Count + 1))]; 
            return winner.FirstName + " " + winner.LastName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {   
            UserInterface.DisplayWinner(contestant);
        }
        public void SendMessage()
        {
            foreach (var item in dictionaryOfContestants)
            {
                if (item.Key.Equals(winner.registrationNum))
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Sweepstakes"));
                    message.To.Add(new MailboxAddress(winner.FirstName + " " + winner.LastName, winner.Email));
                    message.Subject = name + " Sweepstakes";
                    message.Body = new TextPart("plain")
                    {
                        Text = @"Congratulation " + winner.FirstName + @",

I just wanted to inform you that you are the winner to the " + name + @" sweepstakes."
                    };
                }
                else
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Sweepstakes"));
                    message.To.Add(new MailboxAddress(item.Value.FirstName + " " + item.Value.LastName, item.Value.Email));
                    message.Subject = name + " Sweepstakes";
                    message.Body = new TextPart("plain")
                    {
                        Text = @"Unfortuantely " + item.Value.FirstName + @",

I just wanted to inform you that you are not the winner to " + name + @" sweepstake."

                    };
                }
            }
            
        }
    }
}
