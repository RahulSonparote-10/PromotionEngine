using Promotion.Business;
using Promotion.Interfaces;
using Promotion.Models;
using System;
using System.Collections.Generic;

namespace Promotion
{
    class Program
    {
        public static PromotionEngine promotionEngine = new PromotionEngine();

        static void Main(string[] args)
        {
            DisplayUnitMenu();
            DisplayActivePromotion();
            int item, quantity, totalBill = 0;
            List<Unit> lstSelectedItems = new List<Unit>();
            string key = "Y";
            while (key == "Y" || key == "y")
            {
                item = SelectMenu();
                quantity = SelectQuantity();
                totalBill = totalBill + promotionEngine.CalculateBill(item, quantity);
                lstSelectedItems.Add(new Unit { UnitName = item.ToString(), Quantity = quantity });

                Console.Write("Do you want to add more items (Y/N)? ");
                key = Console.ReadLine();
            }
            if (totalBill > 0 && lstSelectedItems.Count > 0)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You have selected below items");
                for (int i = 0; i < lstSelectedItems.Count; i++)
                {
                    Console.WriteLine("Item Number {0} : {1}", lstSelectedItems[i].UnitName, lstSelectedItems[i].Quantity);
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Your total bill is {0}", totalBill);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            
        }
        static public int SelectQuantity()
        {
            Console.Write("Enter Quantity :");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
        static public void DisplayUnitMenu()
        {
            Console.WriteLine("************Menu Items************");
            var menuList = promotionEngine.GetUnits();
            for (int i = 0; i < menuList.Count; i++)
            {
                Console.WriteLine("{0}. {1} (Price - {2})", i+1, menuList[i].UnitName, menuList[i].Price);
            }

        }
        static public int SelectMenu()
        {
            Console.Write("Select Unit :");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
        static public void DisplayActivePromotion()
        {
            Console.WriteLine("*********Active Promotions********");
            var promotionList = promotionEngine.GetPromotions();
            for (int i = 0; i < promotionList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, promotionList[i].Description);
            }
            Console.WriteLine("--------------------------------");
        }
    }
}
