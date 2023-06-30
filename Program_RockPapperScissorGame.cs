using Microsoft.VisualBasic;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] decision = { "ROCK", "PAPPER", "SCISSOR" } ;
            int Point_User = 0, Point_CPU = 0;
            int True = 1;
            Console.WriteLine("***********PLAY********");
            Console.WriteLine("  ROCK PAPPER SCISSOR");
            while (True==1)
            {
                Console.WriteLine("UR Choice to make a Nice Shot");
                string User_Decision =  Console.ReadLine();
                string CPU_Decision = decision[random.Next(decision.Length)];
                switch (User_Decision.ToUpper())
                {
                    case "ROCK":
                        if (CPU_Decision == "SCISSOR")
                            Point_User += 1;
                        else if (CPU_Decision == "PAPPER" )
                            Point_CPU += 1;
                        break;
                    case "PAPPER":
                        if (CPU_Decision == "ROCK")
                            Point_CPU += 1;
                        else if (CPU_Decision == "SCISSOR")
                            Point_User += 1;
                        break;
                    case "SCISSOR":
                        if (CPU_Decision == "ROCK")
                            Point_CPU += 1;
                        else if (CPU_Decision == "PAPPER")
                            Point_User += 1;
                        break;
                    default:
                        Console.WriteLine("Wrong Case");
                        break;
                }
                Console.WriteLine("Want to play ....1-PLAYAGAIN /nelse... 2-QUIT");
                True = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("PLAYER SCORE |  CPU SCORE");
            Console.WriteLine("    " + Point_User + "            |    " + Point_CPU);
            if (Point_User > Point_CPU)
                Console.WriteLine("@@@@@@@@@You Win@@@@@@@");
            else if (Point_User == Point_CPU)
                Console.WriteLine("----------tied------------");
            else
                Console.WriteLine("@@@@@@@@@You Lose@@@@@@");
        }
    }
}
