using System;

namespace Dairy
{
    class Program
    {    
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO OUR DAIRY CALCULATOR!");
            Console.WriteLine(new string('=', 32));
            
            // There is no need to create an object to call a static method.
            calculateDairyProfit();
        }

        static void calculateDairyProfit(){
            
            float totalMilkProduced;
            int totalCartons;
            float costOf1Litre=0.38f;
            float profitOf1Carton=0.27f;
            float totalCost;
            float totalProfit;
            Console.WriteLine("How much milk is produced in the morning?");
            totalMilkProduced=float.Parse(Console.ReadLine());
            Console.WriteLine($"\n{totalMilkProduced} litres of milk is produced in the morning. \n");

            
            totalCartons=Convert.ToInt32(totalMilkProduced/3.78f);
            Console.WriteLine($"{totalCartons} cartons are required to hold the milk.");

            totalCost=totalMilkProduced*costOf1Litre;
            Console.WriteLine($"\nThe cost of producing {totalMilkProduced} litres of milk is ${Math.Round(totalCost,2)}.");

            totalProfit=totalCartons*profitOf1Carton;
            Console.WriteLine($"\nThe total profits on {totalCartons} cartons is ${Math.Round(totalProfit,2)}.");
        }
    }
}
