﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Interfaces
{
    public interface ISweetness
    {
        double SugarPerUnit { get; }
        double Weight { get; }
        string Name { get; }
        double CaloriPerUnit { get; }
        double Price { get; }
        string TypeOfSweetness { get; }
        string ItemInfo { get; }
        string TypeOfIngredients { get; }
    }

   
}
