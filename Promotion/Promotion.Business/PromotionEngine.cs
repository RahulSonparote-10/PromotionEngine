using Promotion.Interfaces;
using Promotion.Models;
using Promotion.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion.Business
{
    public class PromotionEngine : IPromotionEngine
    {
        public static bool isPromotionApplied;
        public int CalculateBill(int item, int quntity)
        {
            var combos = 0;
            var singleItems = 0;
            var totalCost = 0;
            switch (item)
            {
                case 1:
                    combos = quntity / 3;
                    singleItems = quntity % 3;
                    if (combos != 0 && !isPromotionApplied)
                    {
                        isPromotionApplied = true;
                        totalCost = combos * 130 + singleItems * Utility.unitACost;
                    }
                    else
                    {
                        totalCost = quntity * Utility.unitACost;
                    }
                    break;
                case 2:
                    combos = quntity / 2;
                    singleItems = quntity % 2;
                    if (combos != 0 && !isPromotionApplied)
                    {
                        isPromotionApplied = true;
                        totalCost = combos * 45 + singleItems * Utility.unitBCost;
                    }
                    else
                    {
                        totalCost = quntity * Utility.unitBCost;
                    }
                    break;
                case 3:
                    totalCost = quntity * Utility.unitCCost;
                    break;
                case 4:
                    totalCost = quntity * Utility.unitDCost;
                    break;
            }

            return totalCost;
        }

        public List<Promotions> GetPromotions()
        {
            var promotions = new List<Promotions> {
                new Promotions{Description = "3 Of Unit A's for 130", IsActive = true },
                new Promotions{Description = "2 Of Unit B's for 45", IsActive = true },
                new Promotions{Description = "C & D for 30", IsActive = true }
            };
            return promotions;
        }

        public List<Unit> GetUnits()
        {
            var units = new List<Unit> {
            new Unit{
                UnitName = "Unit A",
                Price = 50
            },
             new Unit{
                UnitName = "Unit B",
                Price = 30
            },
              new Unit{
                UnitName = "Unit C",
                Price = 20
            },
               new Unit{
                UnitName = "Unit D",
                Price = 15
            },
            };
            return units;
        }
    }


}
