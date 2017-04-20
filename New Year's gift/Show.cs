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
                Console.WriteLine("Name of sweetnes: {0}, Weight: {1}, SugarPerUnit: {2}, CaloriPerUnit: {3}, Price: {4}, TypeOfSweetness {5}"
                    , i.Name, i.Weight, i.SugarPerUnit, i.CaloriPerUnit, i.Price,i.GetTypeOfSweetness);

            }

        }
    }
}
