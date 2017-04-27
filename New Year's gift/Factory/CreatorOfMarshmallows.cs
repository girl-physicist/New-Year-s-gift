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
    class CreatorOfMarshmallows : Creator
    {
        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfHalva typeOfHalva,  WithNuts withNuts)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string marshmallowsName, double marshmallowsWeight, double marshmallowsPrice
            , double marshmallowsSugar, double marshmallowsCalories, TypeOfMarshmallows typeOfMarshmallows,  DriedFruits driedFruits,Thickener thickener)
        {
            return new Marshmallows(marshmallowsName, marshmallowsWeight, marshmallowsPrice, marshmallowsSugar
             , marshmallowsCalories, typeOfMarshmallows,  driedFruits, thickener);
           
        }

        

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfCandy typeOfCandy, Stuffing stuffing)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa, VariantsOfChocolateProducts variantsOfChocolateProducts)
        {
            throw new NotImplementedException();
        }


    }
}
