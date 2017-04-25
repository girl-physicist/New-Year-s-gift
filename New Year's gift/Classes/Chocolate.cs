using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    class Chocolate : Sweet, IChocolate, IDriedFruits
    {
        public TypeOfChocolate TypeOfChocolate
        {
            get;
        }
        public DriedFruits DriedFruits
        {
            get;
        }
        public double PercentageOfCocoaProducts
        {
            get;
        }
        public Chocolate(string name, double weight, double price, double sugar, double calories
            , TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa) 
            : base(name, weight, price, sugar, calories)
        {
            TypeOfChocolate = typeOfChocolate;
            DriedFruits = driedFruits;
            PercentageOfCocoaProducts = cocoa;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Chocolate"; }
        }
        public override string GetItemsInfo()
        {
            return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories " +
                CaloriPerUnit + " Type Of Chocolate " + TypeOfChocolate
                + " "+ PercentageOfCocoaProducts+"% "+ "Contains "+ DriedFruits);
        }
    }
}
