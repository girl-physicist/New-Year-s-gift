using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Classes;
using New_Year_s_gift.Interfaces;

namespace New_Year_s_gift.Factory
{
    class CreatorOfMarshmallows : Creator
    {
        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfHalva typeOfHalva)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string marshmallowsName, double marshmallowsWeight, double marshmallowsPrice
            , double marshmallowsSugar, double marshmallowsCalories, TypeOfMarshmallows typeOfMarshmallows)
        {
            return new Marshmallows(marshmallowsName, marshmallowsWeight, marshmallowsPrice, marshmallowsSugar
                , marshmallowsCalories, typeOfMarshmallows);
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfKozinak typeOfKozinak)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfCandy typeOfCandy)
        {
            throw new NotImplementedException();
        }

        public override Sweet FactoryMethod(string name, double weight, double price, double sugarPerUnit
            , double caloriPerUnit, TypeOfChocolate typeOfChocolate)
        {
            throw new NotImplementedException();
        }


    }
}
