using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    class Chocolate : Sweet, IChocolate, IContainingDriedFruits
    {
        public TypeOfChocolate TypeOfChocolate
        {
            get;
        }
        public Chocolate(string name, double weight, double price, double sugar, double calories
            , TypeOfChocolate typeOfChocolate, DriedFruits driedFruits) : base(name, weight, price, sugar, calories)
        {
            TypeOfChocolate = typeOfChocolate;
            DriedFruits = driedFruits;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Chocolate"; }
        }

        public DriedFruits DriedFruits
        {
            get;
        }
    }
}
