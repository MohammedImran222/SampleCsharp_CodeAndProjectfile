using Microsoft.VisualBasic;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            float Numeric_1, Numeric_2;
            char Operators;
            char Total = '.';
            Console.WriteLine("*********Normal_Calculator********");
            Console.WriteLine("Enter thr Number1 ");
            Numeric_1 = Convert.ToInt32(Console.ReadLine());
            while (Total != '=')
            {
                if (Total == '.')
                {
                    Console.WriteLine("Enter the Mathematic Operator to calculate(+,-,*,/)");
                    Operators = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    Operators = Total;
                }
                Console.WriteLine("Enter the Number2 ");
                Numeric_2 = Convert.ToInt32(Console.ReadLine());
                switch (Operators)
                {
                    case '+':
                        Numeric_1 = Numeric_1 + Numeric_2;
                        break;
                    case '-':
                        Numeric_1 = Numeric_1 - Numeric_2;
                        break;
                    case '*':
                        Numeric_1 = Numeric_1 * Numeric_2; 
                        break;
                    case '/':
                        Numeric_1 = Numeric_1 / Numeric_2;
                        break;
                    default:
                        Console.WriteLine("Sorry Operator not exist");
                        break;
                }
                Console.WriteLine("Want to do any operation Enter any operator[+, - , * ,/ ] /n else Enter =");
                Total = Convert.ToChar(Console.ReadLine());
                if (Total == '+' || Total == '-' || Total== '*' || Total == '/'|| Total == '=')
                {
                    continue;
                }
                else
                {
                    Total = Convert.ToChar(Console.ReadLine());
                }
            }    
            Console.WriteLine("Total Value is "+ Numeric_1);
        }
    }
}
