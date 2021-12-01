using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Clone
{
    public class PlayArea
    {
        public List<string> GestureList = new();
        public int MaxScore;
        public List<Player> Players = new();

        public PlayArea()
        {
            this.GestureList.Add("Rock");
            this.GestureList.Add("Paper");
            this.GestureList.Add("Scissors");
            this.GestureList.Add("Lizard");
            this.GestureList.Add("Spock");
        }

        public void AddPlayersPvp()
        {
            Human PlayerOne = new(0,-1,"");
            PlayerOne.GetName();
            Human PlayerTwo = new(0, -1, "");
            PlayerTwo.GetName();
            this.Players.Add(PlayerOne);
            this.Players.Add(PlayerTwo);
        }

        public void AddPlayersPvAi()
        {
            Human PlayerOne = new(0, -1, "");
            PlayerOne.GetName();
            Robot PlayerTwo = new(0, -1);
            this.Players.Add(PlayerOne);
            this.Players.Add(PlayerTwo);
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard");
            Console.WriteLine("\nLizard poisons Spock\nSpock smashes Scissors \nScissors decapitates Lizard\n");
        }

        public void ChooseGameMode()
        {
            string UserInput = "0";

            do
            {
                Console.WriteLine("Choose a game mode: \n1: singleplayer\n2: multiplayer");
                UserInput = Console.ReadLine();
            }
            while (UserInput != "1" || UserInput != "2");

            if (UserInput == "1")
            {
                this.AddPlayersPvAi();
            }

            else if (UserInput == "2")
            {
                this.AddPlayersPvp();
            }
        }

        public void CompareGestures(int P1Pick, int P2Pick)
        {
            int[,] GestureArray = new int[,]
            {
                {0, -1, 1, 1, -1},
                {1, 0, -1, -1, 1},
                {-1, 1, 0, 1, -1},
                {-1, 1, -1, 0, 1},
                {1, -1, 1, -1, 0}
            };

            int Winner = GestureArray[P1Pick, P2Pick];

            if (Winner == 1)
            {
                Console.WriteLine($"{this.Players[1].Name} has won this round with {this.GestureList[P2Pick]}!\n");
                this.Players[1].Score += 1;
            }
            else if (Winner == 0)
            {
                Console.WriteLine($"Both players chose {this.GestureList[P2Pick]}! This round is a tie!\n");
            }
            else if (Winner == 1)
            {
                Console.WriteLine($"{this.Players[0].Name} has won this round with {this.GestureList[P1Pick]}!\n");
                this.Players[0].Score += 1;
            }
        }

        public void PlayRound()
        {
            Console.WriteLine("Please input the number of the Gesture you would like.");
            Console.WriteLine("1.) Rock ✊");
            Console.WriteLine("2.) Paper 🤚");
            Console.WriteLine("3.) Scissors ✌");
            Console.WriteLine("4.) Lizard 🤏");
            Console.WriteLine("5.) Spock 🖖");

            int UserInputOne = 0;
            int UserInputTwo = 0;

            while (UserInputOne < 1 && UserInputOne > 6)
            {
                Console.WriteLine("Enter number: ");
                string value = Console.ReadLine();
                UserInputOne = (int)Convert.ToUInt32(value);
            }
            this.Players[0].PickGesture(UserInputOne);

            if (this.Players[1].Name == "MasterMind")
            {
                // Random number
            }

        }

    }
}
