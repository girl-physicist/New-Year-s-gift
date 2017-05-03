using New_Year_s_gift.Enum;
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
        public Stuffing Stuffing;
        public Candy(string name, double weight, double price, double sugar, double calories
            , TypeOfCandy typeOfCandy, Stuffing stuffing)
            : base(name, weight, price, sugar, calories)
        {
            TypeOfCandy = typeOfCandy;
            Stuffing = stuffing;
        }
        public override string TypeOfSweetness => "Candy";
        public override string TypeOfIngredients => string.Format("{0}", TypeOfCandy);
        //добавить вспомогательный класс, в нем реализовать передачу необходимых параметров
        public override string ItemInfo => string.Format(" {0},  weight: {1}, price: {2}, sugar: {3}, calories: {4}" +
                        ",  {5} ", Name, Weight, Price, SugarPerUnit, CaloriPerUnit,Stuffing);

       
    }
}
