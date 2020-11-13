using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        //tracks the scores and ends the game when one player reaches 3
        static void gameManager()
        {
            int playerScore = 0;
            int computerScore = 0;

            while(playerScore != 3 && computerScore != 3){
                Console.WriteLine("---------------------------");
                Console.WriteLine("| Player: 0 | Computer: 0 |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("What Would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");

                string playerTurn = Console.ReadLine();
                string computerTurn = GetComputerTurn();
                if(computerTurn == "1" && playerTurn == "1"){
                    printRock();
                    Console.WriteLine("VS");
                    printRock();
                }
                else if(computerTurn == "2" && playerTurn == "2"){
                    printPaper();
                    Console.WriteLine("VS");
                    printPaper();
                }
            }
            

        }

        //return a random string of either 1, 2, or 3
        static string GetComputerTurn()
        {
            string playerTurn = Console.ReadLine();
            Random r = new Random();
            string randomNumber = r.Next(1,4).ToString();
            return randomNumber;
        }

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

        static void printPaper(){
            Console.WriteLine(@"
                 _______
            ---'    ____)____
                        ______)
                        _______)
                        _______)
                ---.__________)
            ");
        }

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
