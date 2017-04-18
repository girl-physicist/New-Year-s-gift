using New_Year_s_gift.Classes;
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
        public abstract Sweet FactoryMethod(string name, double weight, double price, double SugarPerUnit, double CaloriPerUnit, TypeOfCandy TypeOfCandy);
        public abstract Sweet FactoryMethod(string name, double weight, double price, double SugarPerUnit, double CaloriPerUnit, TypeOfChocolate TypeOfChocolate);



    }
}
