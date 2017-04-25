using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    class Candy : Sweet, ICandy
    {
        public TypeOfCandy TypeOfCandy
        {
            get;
        }
        public Candy(string name, double weight, double price, double sugar, double calories, TypeOfCandy typeOfCandy)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfCandy = typeOfCandy;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Candy"; }
        }

        public override string GetItemsInfo()
        {
            return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit + " calories " +
                CaloriPerUnit + " TypeOfCandy " + TypeOfCandy);
        }
    }
}
