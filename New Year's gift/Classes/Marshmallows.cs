﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    public class Marshmallows : Sweet
    {
        public TypeOfMarshmallows TypeOfMarshmallows;
        public Marshmallows(string name, double weight, double price, double sugar, double calories, TypeOfMarshmallows typeOfMarshmallows)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfMarshmallows = typeOfMarshmallows;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Marshmallows"; }
        }
    }
}