using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    public class Halva : Sweet
    {
        public TypeOfHalva TypeOfHalva;
        
        public Halva(string name, double weight, double price, double sugar, double calories, TypeOfHalva typeOfHalva)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfHalva = typeOfHalva;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Halva"; }
        }

        public override string ShowItems1()
        {
            return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories " +
                CaloriPerUnit + " TypeOfCandy " + TypeOfHalva);
        }
    }
}
