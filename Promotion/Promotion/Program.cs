using System;

namespace Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayActivePromotion();
            var item = DisplayUnitMenu();
            var Quantity = DisplayQuantity();
            if (item == 1)
            {
                var combos = Quantity / 3;
                var singleItems = Quantity % 3;
                var TotalCost = combos * 130 + singleItems * 50;
                Console.WriteLine("Your total bill amount is {0}", TotalCost);
            }
            Console.WriteLine("You have selected {0} and quantity is {1}",item,Quantity);
        }
        static public int DisplayQuantity()
        {
            Console.WriteLine("Enter Quantity");
            Console.WriteLine();
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
        static public int DisplayUnitMenu()
        {
            Console.WriteLine("Select Unit");
            Console.WriteLine();
            Console.WriteLine("1. Unit A (Price - 50)");
            Console.WriteLine("2. Unit B (Price - 30)");
            Console.WriteLine("3. Unit C (Price - 20)");
            Console.WriteLine("4. Unit D (Price - 15)");
            
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
        static public void DisplayActivePromotion()
        {
            Console.WriteLine("*******Active Promotions********");
            Console.WriteLine();
            Console.WriteLine("1. 3 Of Unit A's for 130");
            Console.WriteLine("2. 2 Of Unit B's for 45");
            Console.WriteLine("--------------------------------");
        }
    }
}
