using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift
{
    public static class Show
    {
        public static void ShowItems(this IGift gift)
        {
            Console.WriteLine(gift.GiftName);
           
            foreach (var i in gift.Items)
            {
               
                Console.WriteLine("{0}, {1}, {2}",
                   i.GetTypeOfSweetness,i.TypeOfIngredients, i.GetItemInfo);
                Console.WriteLine("/-------------------------------------------/");
               
            }

            Console.WriteLine("Sort Sweetness By Weight");
            //foreach (var i in gift.)?????????????????
            //{
            //    Console.WriteLine("{0}, {1}, {2}",
            //       i.GetTypeOfSweetness, i.TypeOfIngredients, i.GetItemInfo);
            //    Console.WriteLine();
            //}
        }
    }
}
