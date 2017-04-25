using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    public class Sweet : ISweetness
    {
        public double CaloriPerUnit
        {
            get;
        }
        public string Name
        {
            get;
        }
        public double Price
        {
            get;
        }
        public double SugarPerUnit
        {
            get;
        }
        public double Weight
        {
            get;
        }

        public Sweet(string name, double weight, double price, double sugar, double calories)
        {
            Name = name;
            Weight = weight;
            Price = price;
            SugarPerUnit = sugar;
            CaloriPerUnit = calories;


        }
        public virtual string GetTypeOfSweetness
        {
            get;
        }
        public virtual string GetItemsInfo()
        {
            //return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit +
            //    " calories " + CaloriPerUnit);
            //return ("Name " + Name + " weight " + Weight + " price " + Price + " sugar " + SugarPerUnit +
            //    " calories " + CaloriPerUnit);

           return string.Format( "{0},  weight: {1}, price: {2}, sugar: {3}, calories: {4} ",
               Name,Weight , Price ,SugarPerUnit ,CaloriPerUnit);
        }


    }
}
