using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Clone
{
    public class Human : Player
    {
        public string Name;

        public Human(int score, int currentPick, string name)
        {
            Score = score;
            CurrentPick = currentPick;
            Name = name;
        }

        public void GetName()
        {
            Console.WriteLine("Enter Your name here: ");
            string UserInput = Console.ReadLine();
            this.Name = UserInput;
        }
    }
}