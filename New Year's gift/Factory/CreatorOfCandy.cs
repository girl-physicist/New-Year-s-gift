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
    class CreatorOfCandy : Creator
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

        

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa, bool porous)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string candyName, double candyWeight, double candyPrice
            , double candySugar, double candyCalories, TypeOfCandy typeOfCandy,bool withStaffing)
        {
            return new Candy(candyName, candyWeight, candyPrice, candySugar, candyCalories, typeOfCandy,withStaffing);
        }
        
    }
}
