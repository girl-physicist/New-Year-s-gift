using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Year_s_gift.Enum;

namespace New_Year_s_gift.Classes
{
    public class Halva : Sweet,ICoveredWithChocolate
    {
        public TypeOfHalva TypeOfHalva;
        public bool CoveredWithChocolate { get; }
        public bool WithNuts;
        public Halva(string name, double weight, double price, double sugar, double calories, TypeOfHalva typeOfHalva
            , bool coveredWithChocolate,bool withNuts)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfHalva = typeOfHalva;
            CoveredWithChocolate = coveredWithChocolate;
            WithNuts = withNuts;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Halva"; }
        }

        

        public override string GetItemsInfo()
        {
        if (CoveredWithChocolate == true&& WithNuts==false)
            { return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}, Type Of halva {5}, Halva in chocolate"
               , Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfHalva);
            }
        else if (CoveredWithChocolate == true && WithNuts ==true)
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}, Type Of halva {5}, Halva in chocolate with nuts"
                 , Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfHalva);
            }
        else if (CoveredWithChocolate == false && WithNuts == true)
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}, Type Of halva {5}, Halva with nuts"
                 , Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfHalva);
            }
        else
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}, Type Of halva {5}"
                 , Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfHalva);
            }
        }
    }
}
