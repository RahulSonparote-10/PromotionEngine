﻿using Promotion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion.Interfaces
{
    public interface IPromotionEngine
    {
        List<Unit> GetUnits();
        List<Promotions> GetPromotions();
        int CalculateBill(int item, int quntity);

    }
}
