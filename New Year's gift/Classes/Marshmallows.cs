using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    public class Marshmallows : Sweet, IDriedFruits
    {
        public TypeOfMarshmallows TypeOfMarshmallows;
        public DriedFruits DriedFruits
        {
            get;
        }
        public Thickener Thickener;
        public Marshmallows(string name, double weight, double price, double sugar, double calories
            , TypeOfMarshmallows typeOfMarshmallows, DriedFruits driedFruits, Thickener thickener)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfMarshmallows = typeOfMarshmallows;
            DriedFruits = driedFruits;
            Thickener = thickener;
        }
        public override string GetTypeOfSweetness => "Marshmallows";
        public override string TypeOfIngredients => string.Format("Type Of Marshmallows: {0}", TypeOfMarshmallows);
        public override string GetItemInfo => string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                    ", Type of Thickener {5}, {6}", Name, Weight, Price, SugarPerUnit, CaloriPerUnit, Thickener, DriedFruits);


    }
}
