using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORSGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            string computerInput;
            int randomInt;
            bool playAgain = true;

            Random rnd = new Random();

            Console.Write("Welcome to the ROCK, PAPER, SCISSORS GAME! Ready to play?\n\n");

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write(".   Choose between ROCK, PAPER and SCISSORS: ");
                    playerInput = Console.ReadLine()!;
                    playerInput = playerInput.ToUpper();

                    if (playerInput != "ROCK" && playerInput != "PAPER" && playerInput != "SCISSORS")
                    {
                        Console.WriteLine("Invalid input! Please enter ROCK, PAPER, or SCISSORS.");
                        continue;
                    }

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            computerInput = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            computerInput = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (playerInput == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            computerInput = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("SCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }

                while (true)
                {
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string? loopInput = Console.ReadLine();
                    if (loopInput != null && (loopInput.Equals("y", StringComparison.OrdinalIgnoreCase) || loopInput.Equals("yes", StringComparison.OrdinalIgnoreCase)))
                    {
                        playAgain = true;
                        Console.Clear();
                        break;
                    }
                    else if (loopInput != null && (loopInput.Equals("n", StringComparison.OrdinalIgnoreCase) || loopInput.Equals("no", StringComparison.OrdinalIgnoreCase)))
                    {
                        playAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter 'y' or 'n'.");
                    }
                }
            }
        }
    }
}