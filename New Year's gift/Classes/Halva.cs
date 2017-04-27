using New_Year_s_gift.Interfaces;
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
        public WithNuts WithNuts;
        public Halva(string name, double weight, double price, double sugar, double calories, TypeOfHalva typeOfHalva
           , WithNuts withNuts)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfHalva = typeOfHalva;

            WithNuts = withNuts;
        }
        public override string GetTypeOfSweetness => "Halva";
        public override string TypeOfIngredients => string.Format("Type Of Halva: {0}", TypeOfHalva);
        public override string GetItemInfo => string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}, {5}"
            , Name, Weight, Price, SugarPerUnit, CaloriPerUnit, WithNuts);


    }
}
