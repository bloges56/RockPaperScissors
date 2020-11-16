using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            gameManager();
        }

        //tracks the scores and ends the game when one player reaches 3
        static void gameManager()
        {
            //declare and initialize the scores
            int playerScore = 0;
            int computerScore = 0;

            //keep playing game until either the player or computer reaches 3
            while (playerScore != 3 && computerScore != 3)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("What Would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");

                //get the player's and computer's turns
                int playerTurn = Int32.Parse(Console.ReadLine());
                int computerTurn = GetComputerTurn();
                //print the turn
                printTurn(playerTurn, computerTurn);

                //determine if either the computer or user won then give the winner a point
                if ((playerTurn == 1 && computerTurn == 2) || (playerTurn == 2 && computerTurn == 3) || (playerTurn == 3 && computerTurn == 1))
                {
                    computerScore++;
                }
                else if ((computerTurn == 1 && playerTurn == 2) || (computerTurn == 2 && playerTurn == 3) || (computerTurn == 3 && playerTurn == 1))
                {
                    playerScore++;
                }

            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
            Console.WriteLine("---------------------------");

            if(playerScore == 3)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }


        }

        //return a random string of either 1, 2, or 3
        static int GetComputerTurn()
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 4);
            return randomNumber;
        }

        //Print the both the players and computers hand as well as the VS
        static void printTurn(int player, int computer)
        {
            printASCII(player);
            Console.WriteLine("VS");
            printASCII(computer);

        }

        //Print the hand ascii art depending on the given int
        static void printASCII(int choice)
        {
            if (choice == 1)
            {
                printRock();
            }
            else if (choice == 2)
            {
                printPaper();
            }
            else
            {
                printScissors();
            }
        }

        //print rock ASCII
        static void printRock()
        {
            Console.WriteLine(@"  
                _______
            ---'   ____)
                (_____)
                (_____)
                (____)
          ---.__(___)");
        }

        //print paper ASCII
        static void printPaper()
        {
            Console.WriteLine(@"
                 _______
            ---'    ____)____
                        ______)
                        _______)
                        _______)
                ---.__________)
            ");
        }

        //print scissors ascii
        static void printScissors()
        {
            Console.WriteLine(@"
                _______
            ---'   ____)____
                        ______)
                    __________)
                    (____)
              ---.__(___)
            ");
        }

    }
}
