using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    public class Kozinak : Sweet,IChocolate
    {
        public TypeOfKozinak TypeOfKozinak;
        public bool CoveredWithChocolate;
        public TypeOfChocolate TypeOfChocolate
        { get; }
        public double PercentageOfCocoaProducts
        { get; }
        public Kozinak(string name, double weight, double price, double sugar, double calories
            , TypeOfKozinak typeOfKozinak, bool coveredWithChocolate, TypeOfChocolate typeOfChocolate, double cocoa)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfKozinak = typeOfKozinak;
            CoveredWithChocolate = coveredWithChocolate;
            TypeOfChocolate= typeOfChocolate;
            PercentageOfCocoaProducts = cocoa;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Kozinak"; }
        }
        public override string GetItemsInfo()
        {
            if (CoveredWithChocolate == true)
            {
                return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories "
                    + CaloriPerUnit + " TypeOfCandy " + TypeOfKozinak+ " Covered With "+ TypeOfChocolate
                  +" Chocolate " + PercentageOfCocoaProducts+"%");
            }
            else
            {
                return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories " +
                 CaloriPerUnit + " TypeOfCandy " + TypeOfKozinak);
            }
        }
    }
}
