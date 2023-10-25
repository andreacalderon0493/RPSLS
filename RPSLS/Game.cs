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
                "\nSpock vaporizes Rock\n\nBest of 3 wins the game!!" +
                "\n");
        }

        public int ChooseNumberOfHumanPlayers()

        {
            Console.WriteLine("How many people are playing today?\n1 or 2");
            int numberOfHumanPlayers = int.Parse(Console.ReadLine());
            return numberOfHumanPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            //give value to playerOne and playerTwo
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Player One please enter your name");
                string playerOneInput = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneInput);
                playerTwo = new ComputerPlayer("R2D2");

            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player One please enter your name");
                string playerOneInput = Console.ReadLine();
                playerOne = new HumanPlayer(playerOneInput);
                Console.WriteLine("Player Two please enter your name");
                string playerTwoInput = Console.ReadLine();
                playerTwo = new HumanPlayer(playerTwoInput);

            }

        }

        public void CompareGestures()
        {
            Console.WriteLine($"\n{playerOne.name} chooses {playerOne.chosenGesture}\n");
            Console.WriteLine($"{playerTwo.name} chooses {playerTwo.chosenGesture}\n");

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                switch (playerOne.chosenGesture)
                {
                    case "rock":
                        if (playerTwo.chosenGesture == "scissors" || playerTwo.chosenGesture == "lizard")
                        {
                            Console.WriteLine($"{playerOne.name} wins this round!!");
                            playerOne.score++;
                        }
                        else
                        {
                            Console.WriteLine($"{playerTwo.name} wins this round!!");
                            playerTwo.score++;
                        }
                        break;
                    case "paper":
                        if(playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "spock" )
                        {
                            Console.WriteLine($"({playerOne.name} wins this round!");
                            playerOne.score++;
                        }
                        else
                        {
                            Console.WriteLine($"{playerTwo.name} wins this round!!");
                            playerTwo.score++;
                        }
                        break;
                    case "scissors":
                        if (playerTwo.chosenGesture == "lizard" || playerTwo.chosenGesture == "paper")
                        {
                            Console.WriteLine($"{playerOne.name} wins this round!");
                            playerOne.score++;
                        }
                        else
                        {
                            Console.WriteLine($"{playerTwo.name} wins this round!!");
                            playerTwo.score++;
                        }

                        break;
                    case "lizard":
                        if(playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "spock")
                        {
                            Console.WriteLine($"{playerOne.name} wins this round!");
                            playerOne.score++;

                        }
                        else
                        {
                            Console.WriteLine($"{playerTwo.name} wins this round!!");
                            playerTwo.score++;
                        }
                        break;
                    case "spock":
                        if (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "scissors")
                        {
                            Console.WriteLine($"{playerOne.name} wins this round!");
                            playerOne.score++;
                        }
                        else 
                        {
                            Console.WriteLine($"{playerTwo.name} wins this round!!");
                            playerTwo.score++;
                        }
                        break;





                }
            }
        }



        public void DisplayGameWinner()
        {

            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine($"{playerOne.name} wins the game!");
            }
            else 
            { 
                Console.WriteLine($"{playerTwo.name} wins the game!");
            }
            

        }

        public void RunGame()
        {
            WelcomeMessage();

            int numberOfHumans = ChooseNumberOfHumanPlayers();

            CreatePlayerObjects(numberOfHumans);
            //while loop best of 2
            while (playerOne.score != 2 && playerTwo.score != 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
            }

            DisplayGameWinner();
        }
    }
}
