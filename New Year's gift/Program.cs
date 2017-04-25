using New_Year_s_gift.Classes;
using New_Year_s_gift.Enum;
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
            Creator[] creators = new Creator[4];
            creators[0] = new CreatorOfCandy();
            creators[1] = new CreatorOfChocolate();
            creators[2] = new CreatorOfHalva();
            creators[3] = new CreatorOfMarshmallows();

            IGift gift = new Gift("Gift 1");

            foreach (Creator i in creators)
            {
                if (i is CreatorOfCandy)
                {
                    gift.Add(i.FactoryMethod("M&M", 80, 105, 125, 500, TypeOfCandy.Chocolate,true));
                    gift.Add(i.FactoryMethod("ChupaChups", 25, 75, 70, 420, TypeOfCandy.Lollipop,false));
                }

                if (i is CreatorOfChocolate)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 100, 115, 250, 450, TypeOfChocolate.Milk,DriedFruits.Peanut,70,true));
                    gift.Add(i.FactoryMethod("Алёнка", 150, 115, 250, 450, TypeOfChocolate.Milk,DriedFruits.Nut,50,false));
                }

                if (i is CreatorOfHalva)
                {
                    gift.Add(i.FactoryMethod("В Шоколаде с орехами", 200, 115, 250, 450, TypeOfHalva.NutButterBased,true,true));
                    gift.Add(i.FactoryMethod("халва", 100, 115, 250, 450, TypeOfHalva.TahiniBased,false,false));
                    gift.Add(i.FactoryMethod("В Шоколаде ", 200, 115, 250, 450, TypeOfHalva.NutButterBased, true, false));
                    gift.Add(i.FactoryMethod(" с орехами", 100, 115, 250, 450, TypeOfHalva.TahiniBased, false, true));
                }

               

                if (i is CreatorOfMarshmallows)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 150, 115, 250, 450, TypeOfMarshmallows.WhitePink,true,DriedFruits.Peanut));
                    gift.Add(i.FactoryMethod("Красный пищевик", 100, 115, 250, 450, TypeOfMarshmallows.Vanilla,false,DriedFruits.DriedApricots));
                }
                
            }

            gift.Sort();
            gift.ShowItems();

            Console.WriteLine();
            foreach (var items in gift.FindCandyBySugar(50, 100))
            {
                Console.WriteLine("Name: {0}, SugarPerUnit: {1}", items.Name, items.SugarPerUnit);
            }

            Console.WriteLine();
            Console.WriteLine("GiftWeight: {0}", gift.GiftWeight());
            Console.ReadKey();

        }
    }
}

