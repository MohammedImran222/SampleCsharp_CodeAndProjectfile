using Microsoft.VisualBasic;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y,res;
            Console.WriteLine("Multiplication of two Numbers");
            Console.WriteLine("Enter the Number1 :" );
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Number2 :");
            y = Convert.ToDouble(Console.ReadLine());

            res = Method1(x, y);
            Console.WriteLine("Multiplied Value is "+res);
        }
        static double Method1(double num1,double num2)
        {
            double result = num1*num2;
            return result;
        }
    }
}
