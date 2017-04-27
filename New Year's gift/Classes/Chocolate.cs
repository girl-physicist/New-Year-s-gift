using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    class Chocolate : Sweet, IDriedFruits
    {
        public TypeOfChocolate TypeOfChocolate;
        public double PercentageOfCocoaProducts;
        public VariantsOfChocolateProducts VariantsOfChocolateProducts;
        public DriedFruits DriedFruits { get; }
        public Chocolate(string name, double weight, double price, double sugar, double calories
            , TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa
            , VariantsOfChocolateProducts variantsOfChocolateProducts)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfChocolate = typeOfChocolate;
            DriedFruits = driedFruits;
            PercentageOfCocoaProducts = cocoa;
            VariantsOfChocolateProducts = variantsOfChocolateProducts;
        }
        public override string GetTypeOfSweetness => "Chocolate";
        //{
        //    get { return "Chocolate"; }
        //}
        public override string TypeOfIngredients => string.Format("Type Of Chocolate: {0}", TypeOfChocolate);
        public override string GetItemInfo => string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                    ",  {5} {6}% cocoa products, {7}", Name, Weight, Price, SugarPerUnit, CaloriPerUnit
            , VariantsOfChocolateProducts, PercentageOfCocoaProducts, DriedFruits);
    }
}

