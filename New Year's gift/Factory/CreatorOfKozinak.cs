﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Classes;
using New_Year_s_gift.Interfaces;

namespace New_Year_s_gift.Factory
{
    class CreatorOfKozinak : Creator
    {
        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit, 
            double caloriPerUnit, TypeOfChocolate typeOfChocolate)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string candyName, double candyWeight, double candyPrice, 
            double candySugar, double candyCalories, TypeOfCandy typeOfCandy)
        {
            return new Candy(candyName, candyWeight, candyPrice, candySugar, candyCalories, typeOfCandy);
        }
    }
}
