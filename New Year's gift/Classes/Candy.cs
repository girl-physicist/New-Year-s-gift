using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    class Candy : Sweet, ICandy
    {
        public TypeOfCandy TypeOfCandy
        {
            get;
        }
        public Candy(string name, double weight, double price, double sugar, double calories
            , TypeOfIngredients typeOfIngredients, TypeOfCandy typeOfCandy)
            : base(name, weight, price, sugar, calories, typeOfIngredients)
        {
            TypeOfCandy = typeOfCandy;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Candy"; }
        }
    }
}
