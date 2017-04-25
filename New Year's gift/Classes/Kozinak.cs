using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    public class Kozinak : Sweet
    {
        public TypeOfKozinak TypeOfKozinak;
        public Kozinak(string name, double weight, double price, double sugar, double calories, TypeOfKozinak typeOfKozinak)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfKozinak = typeOfKozinak;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Kozinak"; }
        }
        public override string ShowItems1()
        {
            return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories " +
                CaloriPerUnit + " TypeOfCandy " + TypeOfKozinak);
        }
    }
}
