using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    public class Marshmallows : Sweet
    {
        public TypeOfMarshmallows TypeOfMarshmallows;
        public Marshmallows(string name, double weight, double price, double sugar, double calories
            , TypeOfIngredients typeOfIngredients, TypeOfMarshmallows typeOfMarshmallows)
            : base(name, weight, price, sugar, calories,  typeOfIngredients)
        {
            TypeOfMarshmallows =typeOfMarshmallows;
        }


        public override string GetTypeOfSweetness
        {
            get { return "Marshmallows"; }
        }

        public TypeOfChocolate TypeOfChocolate
        {
            get;
        }
    }
}
