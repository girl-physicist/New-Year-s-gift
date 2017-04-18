using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    class Chocolate : Sweet
    {
        public TypeOfChocolate TypeOfChocolate;
        public Chocolate(string name, double weight, double price, double sugar, double calories, TypeOfChocolate typeOfChocolate)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfChocolate = typeOfChocolate;
        }
    }
}
