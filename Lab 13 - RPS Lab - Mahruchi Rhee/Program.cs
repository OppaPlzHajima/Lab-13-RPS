using System;
using System.Runtime.Serialization;

namespace Lab_13___RPS_Lab___Mahruchi_Rhee
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerScore = 0;
            int playerScore = 0;
            string inputCPU;
            int randomInt;
            string response = "Y";


                Console.WriteLine("Hello and welcome to ROCK, PAPER, SCISSORS!!\n\n");
                Console.WriteLine("Please enter your character's name: ");
            string playerName = Console.ReadLine().ToUpper() + " The Genius";

            Console.WriteLine("Who would you like to play against? \n");
            Console.WriteLine(" Type 1 for Ricky Fast Hands");
            Console.WriteLine(" Type 2 for Billy One Eyed Thorton");

            while (response == "Y" || response == "y")
            {
                try
                {
                    Console.WriteLine("Choose between ROCK, PAPER and SCISSORS:    ");
                    string inputPlayer = Console.ReadLine().ToUpper();


                    Random Roshambo = new Random();

                    randomInt = Roshambo.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";

                            Console.WriteLine("The COMPUTER chose ROCK!!\n\n");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine($"{playerName} chose ROCK!!");
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine($"{playerName} chose PAPER!!");
                                Console.WriteLine($"{playerName} wins!!\n\n");
                                playerScore++;
                            }

                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine($"{playerName} chose SCISSORS!!");
                                Console.WriteLine("The COMPUTER wins!!\n\n");
                                computerScore++;
                            }

                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("The COMPUTER chose PAPER!!\n\n");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine($"{playerName} chose PAPER!!");
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine($"{playerName} chose SCISSORS!!");
                                Console.WriteLine($"{playerName} wins!!\n\n");
                                playerScore++;
                            }

                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine($"{playerName} chose ROCK!!");
                                Console.WriteLine("The COMPUTER wins!!\n\n");
                                computerScore++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("The COMPUTER chose SCISSORS!!\n\n");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine($"{playerName} chose SCISSORS!!");
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine($"{playerName} chose ROCK!!");
                                Console.WriteLine($"{playerName} wins!!\n\n");
                                playerScore++;
                            }

                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine($"{playerName} chose PAPER!!");
                                Console.WriteLine("The COMPUTER wins!!\n\n");
                                computerScore++;
                            }

                            break;

                        default:
                            Console.WriteLine("This is an invalid entry!\n\n");
                            break;
                    }

                    Console.WriteLine("SCORE:  \n\n");
                    Console.WriteLine($"{playerName}:  " + playerScore);
                    Console.WriteLine("Computer:  " + computerScore);

                    Console.WriteLine("Would you like to try again?? (Y/N)\n\n");
                    response = Console.ReadLine();

                    if (response == "N" || response == "n")
                    {
                        Console.WriteLine("Thanks for playing good bye!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Entry!");
                }

            }
        }
    }
}

             