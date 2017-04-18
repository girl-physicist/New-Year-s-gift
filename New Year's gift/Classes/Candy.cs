using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    class Candy : Sweet
    {
        public TypeOfCandy TypeOfCandy;
        public Candy(string name, double weight, double price, double sugar, double calories, TypeOfCandy typeOfCandy)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfCandy = typeOfCandy;
        }
        //???????????????????
        public new void GetTypeOfSweetness()
        {
            string type = "Candy";
            Console.WriteLine(type);
            Console.ReadKey();
        }
    }
}
