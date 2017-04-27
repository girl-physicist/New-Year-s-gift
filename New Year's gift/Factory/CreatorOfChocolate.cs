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
            , double caloriPerUnit, TypeOfHalva typeOfHalva, WithNuts withNuts)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfMarshmallows typeOfMarshmallows,  DriedFruits driedFruits, Thickener thickener)
        {
            throw new NotImplementedException();
        }

        

        public override Sweet FactoryMethod(string chocoName, double chocoWeight, double chocoPrice
            , double chocoSugar, double chocoCalories, TypeOfChocolate typeOfChocolate
            , DriedFruits driedFruits, double cocoa,VariantsOfChocolateProducts variantsOfChocolateProducts)
        {
            return new Chocolate(chocoName, chocoWeight, chocoPrice, chocoSugar, chocoCalories
                , typeOfChocolate,driedFruits,cocoa,variantsOfChocolateProducts);
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfCandy typeOfCandy, Stuffing stuffing)
        {
            throw new NotImplementedException();
        }
    }
}
