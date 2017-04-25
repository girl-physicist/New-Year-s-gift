using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    public class Marshmallows : Sweet, ICoveredWithChocolate, IDriedFruits
    {
        public TypeOfMarshmallows TypeOfMarshmallows;
        public bool CoveredWithChocolate
        { get; }
        public DriedFruits DriedFruits
        { get; }
        public Marshmallows(string name, double weight, double price, double sugar, double calories
            , TypeOfMarshmallows typeOfMarshmallows, bool coveredWithChocolate, DriedFruits driedFruits)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfMarshmallows = typeOfMarshmallows;
            CoveredWithChocolate = coveredWithChocolate;
            DriedFruits = driedFruits;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Marshmallows"; }
        }
        public override string GetItemsInfo()
        {
            if (CoveredWithChocolate == true)
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                ", Type Of Marshmallows {5}, Contains {6}, Covered With Chocolate "
                    , Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfMarshmallows, DriedFruits);
            }
            else
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                ", Type Of Marshmallows {5}, Contains {6}"
                    , Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfMarshmallows, DriedFruits);
            }
        }
    }
}
