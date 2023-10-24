using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
        

        //Constructor
        public Game()
        {
            
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\nRock crushes Scissors" +
                "\nScissors cuts Paper " +
                "\nPaper covers Rock" +
                "\nRock crushes Lizard" +
                "\nLizard poisons Spock" +
                "\nSpock smashes Scissors" +
                "\nScissors decapitates Lizard" +
                "\nLizard eats Paper" +
                "\nPaper disproves Spock" +
                "\nSpock vaporizes Rock\n\nBest of 3 wins the game!!");
        }

        public int ChooseNumberOfHumanPlayers()

        {
            Console.WriteLine("How many people are playing today?\n 1 or 2");
            int numberOfHumanPlayers = int.Parse (Console.ReadLine());
            return numberOfHumanPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            //give value to playerOne and playerTwo
            if (numberOfHumanPlayers != 1)
               { 
                Console.WriteLine("Player One please enter your name");
                string playerOneinput = Console.ReadLine();
                Player playerOne = new HumanPlayer(playerOneinput);
                Player playerTwo = new ComputerPlayer("");

               }
            if (numberOfHumanPlayers != 2)
            {
                Console.WriteLine("Player One please enter your name");
                string playerOneinput = Console.ReadLine();
                Player playerOne = new HumanPlayer(playerOneinput);
                Console.WriteLine("");

            }

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}
