﻿using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    public class Halva : Sweet
    {
        public TypeOfHalva TypeOfHalva;
        
        public Halva(string name, double weight, double price, double sugar, double calories
            , TypeOfIngredients typeOfIngredients, TypeOfHalva typeOfHalva)
            : base(name, weight, price, sugar, calories,  typeOfIngredients)
        {
            TypeOfHalva = typeOfHalva;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Halva"; }
        }

       
    }
}
