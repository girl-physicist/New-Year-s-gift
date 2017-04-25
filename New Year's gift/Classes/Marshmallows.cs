using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    public class Marshmallows : Sweet
    {
        public TypeOfMarshmallows TypeOfMarshmallows;
        public Marshmallows(string name, double weight, double price, double sugar, double calories, TypeOfMarshmallows typeOfMarshmallows)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfMarshmallows =typeOfMarshmallows;
        }


        public override string GetTypeOfSweetness
        {
            get { return "Marshmallows"; }
        }

       
        public override string ShowItems1()
        {
            return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories " +
                CaloriPerUnit + " TypeOfCandy " + TypeOfMarshmallows);
        }
    }
}
