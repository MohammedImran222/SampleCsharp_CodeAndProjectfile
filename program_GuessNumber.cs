using Microsoft.VisualBasic;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playagain = 1;
            while(playagain == 1)
            {
                Console.WriteLine("<<< Lets Play Guess The Number >>> ");
                int N_Guesses = 0;
                int Guess = 0;
                int Actual_Num = random.Next(1,101);
                Console.WriteLine("<Guess The Number...>");
                while( Actual_Num != Guess ) 
                {   
                    Console.WriteLine("Guess the value..");
                    Guess = Convert.ToInt32(Console.ReadLine());
                    N_Guesses++;
                    if (Actual_Num < Guess)
                        Console.WriteLine("Guessed value is higher than Actual_value.");
                    else if (Actual_Num > Guess)
                        Console.WriteLine("Guessed value is lower than Actual value.");
                }
                Console.WriteLine("You've Done...");
                Console.WriteLine("No of Guesses Taken to Achieve .. " + N_Guesses);
                Console.WriteLine("Want To Playagain Enter 1\n else Enter 0");
                playagain = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
