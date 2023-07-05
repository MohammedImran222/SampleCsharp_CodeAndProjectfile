using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Transactions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String Name;
            double[] doub = new double[10];
            doub[0] = 200;
            doub[1] = 230;
            doub[2] = 250;
            doub[3] = 280;
            doub[4] = 190;
            doub[5] = 160;
            doub[6] = 266;
            doub[7] = 120;
            doub[8] = 200;
            doub[9] = 110;
            Console.Write("Enter Name of Customer: ");
            Name = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            String PhoneNO = Console.ReadLine();
            int[] ItemNo = new int[10];
            int[] ItemCount = new int[10];
            int TotalItemCount;
            Console.Write("Enter Total Item Count : ");
            TotalItemCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i< TotalItemCount; i++)
            {
                Console.Write("Enter Item Number (0-9) : ");
                ItemNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Count of Items Taken In a specific Item :");
                ItemCount[i] = Convert.ToInt32(Console.ReadLine());
            }
            double Total = BillCheckOut(doub,ItemCount,ItemNo);
            Console.WriteLine("************Store CheckOut Monitoring System************* ");
            Console.WriteLine("     ************    LuLu HyperMart    ************       ");
            Console.WriteLine("Grand Total : " + Total); 
           
        }
        static double BillCheckOut(double[] PriceDetails, int[] ItemCount, int[] ItemNo)
        {
            double TotalPrice = 0;
            int j = 0;
            foreach (int i in ItemNo)
            {
                TotalPrice += PriceDetails[i]*ItemCount[j++];
            }
            return TotalPrice;
        }
    }
}
