using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string rounds;
            int CompAns;
            int rtotal;
            string answer;
            int pans;
            string pagain;
            int again;

            do
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors");
                Console.WriteLine("Please enter how many rounds you would like to play between 1 and 10: ");
                rounds = Console.ReadLine();
                int ties = 0, wins = 0, lose = 0;
                if (int.TryParse(rounds, out rtotal) && rtotal >= 1 && rtotal <= 10)
                {
                    Console.WriteLine("Ok we will play for {0} rounds", rtotal);
                    rtotal--;
                    do
                    {
                        Random r = new Random();
                        CompAns = r.Next(1, 3);
                        Console.WriteLine();
                        Console.WriteLine("Please choose 1 for Rock, 2 for Paper, or 3 for Scissors");
                        answer = Console.ReadLine();

                        if (int.TryParse(answer, out pans) && pans >= 1 && pans <= 3)
                        {
                            if (pans == CompAns)
                            {
                                Console.WriteLine("This round was a tie!");
                                ties++;
                                rtotal--;
                            }
                            else if (pans == 1 && CompAns == 3)
                            {
                                Console.WriteLine("Rock crushes scissors! You win");
                                wins++;
                                rtotal--;
                            }
                            else if (pans == 1 && CompAns == 2)
                            {
                                Console.WriteLine("Paper covers rock! Better luck next time");
                                lose++;
                                rtotal--;
                            }
                            else if (pans == 2 && CompAns == 3)
                            {
                                Console.WriteLine("Scissors cut paper! Better luck next time");
                                lose++;
                                rtotal--;
                            }
                            else if (pans == 2 && CompAns == 1)
                            {
                                Console.WriteLine("Paper covers rock! You win");
                                wins++;
                                rtotal--;
                            }
                            else if (pans == 3 && CompAns == 1)
                            {
                                Console.WriteLine("Rock crushes scissors! Better luck next time");
                                lose ++;
                                rtotal--;
                            }
                            else if (pans == 3 && CompAns == 2)
                            {
                                Console.WriteLine("Scissors cut paper! You win");
                                wins ++;
                                rtotal--;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please make a valid choice of 1 for Rock, 2 for Paper, or 3 for Scissors");
                        }

                    } while (rtotal >= 0);
                    
                    Console.WriteLine("Good Game! The score was: ");
                    Console.WriteLine("{0} ties", ties);
                    Console.WriteLine("You won {0} games", wins);
                    Console.WriteLine("You lost {0} games", lose);
                }
                else
                {
                    Console.WriteLine("Please make a valid selection between 1-10");
                }

                Console.WriteLine("Press 1 to play again or any key to quit");
                pagain = Console.ReadLine();
                int.TryParse(pagain, out again);
                if (again == 1)
                {
                    Console.WriteLine("Let's play again!");
                }
                else
                {
                    break;
                }
            } while (again == 1);
            

        }
    }
}
