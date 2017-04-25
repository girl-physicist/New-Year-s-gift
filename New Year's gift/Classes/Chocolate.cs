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
        public bool Porous;
        public Chocolate(string name, double weight, double price, double sugar, double calories
            , TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa, bool porous)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfChocolate = typeOfChocolate;
            DriedFruits = driedFruits;
            PercentageOfCocoaProducts = cocoa;
            Porous = porous;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Chocolate"; }
        }
        public override string GetItemsInfo()
        {
            if (Porous == true)
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                    ", Type Of Chocolate {5} porous {6}%, Contains {7}",
                 Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfChocolate, PercentageOfCocoaProducts, DriedFruits);
            }
            else
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                    ", Type Of Chocolate {5} {6}%, Contains {7}",
                 Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfChocolate, PercentageOfCocoaProducts, DriedFruits);
            }
        }
    }
}
