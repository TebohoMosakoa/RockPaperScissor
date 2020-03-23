using System;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCpu = 0;

                while (scoreCpu < 3 && scorePlayer < 3)
                {
                    Console.Write("Enter R/r for Rock, P/p for Paper and S/s for Scissors:   ");
                    inputPlayer = Console.ReadLine().ToLower();
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Rock";
                            Console.WriteLine("Computer chose Rock");
                            if (inputPlayer == "r")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "p")
                            {
                                Console.WriteLine("Player win's round");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "s")
                            {
                                Console.WriteLine("Computer Win's round");
                                scoreCpu++;
                            }
                            break;
                        case 2:
                            inputCPU = "Paper";
                            Console.WriteLine("Computer chose Paper");
                            if (inputPlayer == "r")
                            {
                                Console.WriteLine("Computer win's round");
                                scoreCpu++;
                            }
                            else if (inputPlayer == "p")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (inputPlayer == "s")
                            {
                                Console.WriteLine("Player win's round");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "Scissor";
                            Console.WriteLine("Computer chose Scissor");
                            if (inputPlayer == "r")
                            {
                                Console.WriteLine("Player win's round");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "p")
                            {
                                Console.WriteLine("Computer Win's round");
                                scoreCpu++;
                            }
                            else if (inputPlayer == "s")
                            {
                                Console.WriteLine("Draw");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                    Console.WriteLine("Player score: {0} || Computer score: {1}", scorePlayer, scoreCpu);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Wins the Game");
                }
                else if (scoreCpu == 3)
                {
                    Console.WriteLine("Computer won the game");
                }
                else { }

                Console.WriteLine("Do you want to play again? [y/n]");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (answer == "n")
                {
                    playAgain = false;
                }
                else Console.WriteLine("Invalied Input");
            }
        }
    }
}
