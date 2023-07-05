using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1,Number2;
            Console.WriteLine("Two Number Calculation Program With Try and Ctach Execution ");
            try
            {
                Console.Write("Enter Number 1 : ");
                Number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Number 2: ");
                Number2 = Convert.ToInt32(Console.ReadLine());
                double Result;
                Console.WriteLine("Choose  the Operator To Calculate ( + , - , * , / , % )");
                char cas = Convert.ToChar(Console.ReadLine());
                switch (cas)
                {
                    case '+':
                        Result = Method_Add(Number1,Number2);
                        Console.WriteLine("By Adding two Numbers "+Number1+" + "+Number2+" = " +  Result);
                        break;
                    case '-':
                        Result = Method_Sub(Number1,Number2);
                        Console.WriteLine("By Subtracting two Numbers " + Number1 + " - " + Number2 + " = " + Result);
                        break;
                    case '*':
                        Result = Method_Mul(Number1,Number2);
                        Console.WriteLine("By Multiplying two Numbers " + Number1 + " * " + Number2 + " = " + Result);
                        break;
                    case '/':
                        Result = Method_divide(Number1,Number2);
                        Console.WriteLine("By dividing two Numbers " + Number1 + " / " + Number2 + " = " + Result);
                        break;
                    case '%':
                        Result = Method_Reminder(Number1,Number2);
                        Console.WriteLine("By Moduling two Numbers " + Number1 + " % " + Number2 + " = " + Result);
                        break;
                    default:
                        Console.WriteLine("Wrong choice :: Thank You");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide by Zero : Zero Division Error");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter Only Numbers ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("YES All Done Program Executed...");
            }
        }
        static double Method_Add(int a, int b)
        { return a + b; }
        static double Method_Sub(int a,int b) 
        { return a - b; }
        static double Method_Mul(int a,int b)
        { return a * b; }
        static double Method_divide(int a,int b)
        { return a / b; }
        static double Method_Reminder(int a,int b)
        { return a % b;  }
    }
}
