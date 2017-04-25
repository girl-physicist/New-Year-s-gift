﻿using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    class Chocolate : Sweet, IChocolate
    {
        public TypeOfChocolate TypeOfChocolate
        {
            get;
        }
        public Chocolate(string name, double weight, double price, double sugar, double calories, TypeOfChocolate typeOfChocolate) 
            : base(name, weight, price, sugar, calories)
        {
            TypeOfChocolate = typeOfChocolate;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Chocolate"; }
        }
        public override string ShowItems1()
        {
            return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories " +
                CaloriPerUnit + " TypeOfCandy " + TypeOfChocolate);
        }
    }
}
