using New_Year_s_gift.Classes;
using New_Year_s_gift.Enum;
using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Factory
{
    public abstract class Creator
    {
       
        public abstract Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
           , double caloriPerUnit, TypeOfCandy typeOfCandy,Stuffing stuffing);
        public abstract Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa
            , VariantsOfChocolateProducts variantsOfChocolateProducts);
        public abstract Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfHalva typeOfHalva, WithNuts withNuts);
        public abstract Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfMarshmallows typeOfMarshmallows,  DriedFruits driedFruits, Thickener thickener);
    }
}
