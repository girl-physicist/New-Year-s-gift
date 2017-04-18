using New_Year_s_gift.Classes;
using New_Year_s_gift.Factory;
using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new CreatorOfCandy();
            creators[1] = new CreatorOfChocolate();

            IGift gift = new Gift();

            foreach (Creator i in creators)
            {
                if (i is CreatorOfCandy)
                {
                    gift.Add(i.FactoryMethod("M&M", 80, 105, 125,500, TypeOfCandy.Chocolate));
                    gift.Add(i.FactoryMethod("ChupaChups", 25, 75, 70,420, TypeOfCandy.Lollipop));
                }

                if (i is CreatorOfChocolate)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 100, 115, 250, 450,TypeOfChocolate.Milk));
                }
            }

            gift.Sort();
            gift.ShowItems(); // перепроверить добавление 

            Console.WriteLine();
            foreach (var items in gift.FindCandyBySugar(20, 110))
            {
                Console.WriteLine("Название конфеты: {0}, Сахар: {1}", items.Name, items.SugarPerUnit);
            }

            Console.WriteLine();
            Console.WriteLine("Вес подарка: {0}", gift.GiftWeight());
            Console.ReadKey();

        }
    }
    }

