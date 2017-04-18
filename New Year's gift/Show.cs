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
            Console.WriteLine("Набор конфет: ");
            foreach (var i in gift.items)
            {
                Console.WriteLine("Название конфеты: {0}, Вес конфеты: {1}, Сахар: {2}, Калории: {3}, Цена: {4}"
                    , i.Name, i.Weight, i.SugarPerUnit, i.CaloriPerUnit, i.Price);

            }

        }
    }
}
