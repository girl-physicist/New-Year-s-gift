using New_Year_s_gift.Classes;
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
            Console.WriteLine("{0} consist {1} elements", gift.GiftName, gift.GetCountOfSweet());
            Console.WriteLine();
            Console.WriteLine("GiftWeight: {0}", gift.GiftWeight());
            Console.WriteLine();
            Console.WriteLine("/-------------------------------------------/");
            Console.WriteLine();
            foreach (var i in gift.Items)
            {
                Console.WriteLine("{0}, {1}, {2}", i.GetTypeOfSweetness, i.TypeOfIngredients, i.GetItemInfo);
            }
            Console.WriteLine();
            Console.WriteLine("/-------------------------------------------/");
            Console.WriteLine("Sort Sweetness By Weight");
            Console.WriteLine();
            var temp = gift.SortSweetnessByWeight();
            foreach (var i in temp)
            {
                Console.WriteLine("{0}, {1}, {2}", i.GetTypeOfSweetness, i.Name, i.Weight);
            }
            Console.WriteLine();
            Console.WriteLine("/-------------------------------------------/");
            Console.WriteLine("FindSweetnessBySugar ");
            Console.WriteLine();
            Console.WriteLine("Enter min value Sugar");
            var min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max value Sugar");
            var max = Convert.ToInt32(Console.ReadLine());
            foreach (var items in gift.FindSweetnessBySugar(min, max))
            {
                Console.WriteLine("Name: {0}, SugarPerUnit: {1}", items.Name, items.SugarPerUnit);
            }
            Console.ReadKey();
        }
    }
}
