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
    class CreatorOfHalva : Creator
    {
        public override Sweet FactoryMethod(string halvaName, double halvaWeight, double halvaPrice, double halvaSugar
            , double halvaCalories, TypeOfHalva typeOfHalva, WithNuts withNuts)
        {
            return new Halva(halvaName, halvaWeight, halvaPrice, halvaSugar, halvaCalories, typeOfHalva,withNuts);
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfCandy typeOfCandy, Stuffing stuffing)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfMarshmallows typeOfMarshmallows, DriedFruits driedFruits, Thickener thickener)
        {
            throw new NotImplementedException();
        }

       

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa,  VariantsOfChocolateProducts variantsOfChocolateProducts)
        {
            throw new NotImplementedException();
        }
    }
}
