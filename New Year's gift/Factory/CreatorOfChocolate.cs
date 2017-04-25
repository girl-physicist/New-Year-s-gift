using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Classes;
using New_Year_s_gift.Interfaces;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Factory
{
    class CreatorOfChocolate : Creator
    {
        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfHalva typeOfHalva, bool coveredWithChocolate, bool withNuts)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfMarshmallows typeOfMarshmallows, bool coveredWithChocolate, DriedFruits driedFruits)
        {
            throw new NotImplementedException();
        }

        

        public override Sweet FactoryMethod(string chocoName, double chocoWeight, double chocoPrice
            , double chocoSugar, double chocoCalories, TypeOfChocolate typeOfChocolate
            , DriedFruits driedFruits, double cocoa,bool porous)
        {
            return new Chocolate(chocoName, chocoWeight, chocoPrice, chocoSugar, chocoCalories
                , typeOfChocolate,driedFruits,cocoa,porous);
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfCandy typeOfCandy, bool withStaffing)
        {
            throw new NotImplementedException();
        }
    }
}
