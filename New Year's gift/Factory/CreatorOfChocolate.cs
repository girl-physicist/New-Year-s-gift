﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Classes;
using New_Year_s_gift.Interfaces;

namespace New_Year_s_gift.Factory
{
    class CreatorOfChocolate : Creator
    {
        public override Sweet FactoryMethod(string chocoName, double chocoWeight, double chocoPrice,
            double chocoSugar, double chocoCalories, TypeOfChocolate typeOfChocolate)
        {
            return new Chocolate(chocoName, chocoWeight, chocoPrice, chocoSugar, chocoCalories, typeOfChocolate);
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double SugarPerUnit,
            double CaloriPerUnit, TypeOfCandy TypeOfCandy)
        {
            throw new NotImplementedException();
        }
    }
}
