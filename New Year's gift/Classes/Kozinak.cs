using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    public class Kozinak : Sweet, ICoveredWithChocolate
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
    }
}
