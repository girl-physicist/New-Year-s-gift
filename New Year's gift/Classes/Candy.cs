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
        public bool WithStuffing;
        public Candy(string name, double weight, double price, double sugar, double calories, TypeOfCandy typeOfCandy, bool withStuffing)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfCandy = typeOfCandy;
            WithStuffing = withStuffing;
        }
        public override string GetTypeOfSweetness
        {
            get { return "Candy"; }
        }

        public override string GetItemsInfo()
        {
            if (WithStuffing == true)
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                    ", Type Of Candy {5}, With Stuffing ",
                 Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfCandy);
            }
            else
            {
                return string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}, Type Of Candy {5} ",
                 Name, Weight, Price, SugarPerUnit, CaloriPerUnit, TypeOfCandy);
            }
        }
    }
}
