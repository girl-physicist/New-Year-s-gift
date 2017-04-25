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
    class CreatorOfKozinak : Creator
    {
        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfHalva typeOfHalva)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfMarshmallows typeOfMarshmallows)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string kozinakName, double kozinakWeight, double kozinakPrice, double kozinakSugar
            , double kozinakCalories, TypeOfKozinak typeOfKozinak, bool coveredWithChocolate
           , TypeOfChocolate typeOfChocolate, double cocoa)
        {
            if (coveredWithChocolate == true)
            {
                return new Kozinak(kozinakName, kozinakWeight, kozinakPrice, kozinakSugar, kozinakCalories
               , typeOfKozinak, coveredWithChocolate, typeOfChocolate, cocoa);
            }
            else
            {
                return new Kozinak(kozinakName, kozinakWeight, kozinakPrice, kozinakSugar, kozinakCalories
               , typeOfKozinak, coveredWithChocolate, TypeOfChocolate.None, 0);
            }

        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfCandy typeOfCandy)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfChocolate typeOfChocolate, DriedFruits driedFruits, double cocoa)
        {
            throw new NotImplementedException();
        }


    }
}
