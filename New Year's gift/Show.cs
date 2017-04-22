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
                Console.WriteLine("Type of sweetnes: {0}, Name of sweetnes: {1}, Weight: {2}, SugarPerUnit: {3}, CaloriPerUnit: {4}, Price: {5}",
                   i.GetTypeOfSweetness , i.Name, i.Weight, i.SugarPerUnit, i.CaloriPerUnit, i.Price);
            }
        }
    }
}
