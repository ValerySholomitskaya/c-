﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    class Discount1 : IDiscount
    {
        public decimal Discount()
        {
            return (decimal)(0.01);
        }
    }
}
