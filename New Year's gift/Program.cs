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
            Creator[] creators = new Creator[5];
            creators[0] = new CreatorOfCandy();
            creators[1] = new CreatorOfChocolate();
            creators[2] = new CreatorOfHalva();
            creators[3] = new CreatorOfKozinak();
            creators[4] = new CreatorOfMarshmallows();

            IGift gift = new Gift("Gift 1");

            foreach (Creator i in creators)
            {
                if (i is CreatorOfCandy)
                {
                    gift.Add(i.FactoryMethod("M&M", 80, 105, 125, 500, TypeOfCandy.Chocolate));
                    gift.Add(i.FactoryMethod("ChupaChups", 25, 75, 70, 420, TypeOfCandy.Lollipop));
                }

                if (i is CreatorOfChocolate)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 100, 115, 250, 450, TypeOfChocolate.Milk));
                    gift.Add(i.FactoryMethod("Алёнка", 150, 115, 250, 450, TypeOfChocolate.Milk));
                }

                if (i is CreatorOfHalva)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 200, 115, 250, 450, TypeOfHalva.NutButterBased));
                    gift.Add(i.FactoryMethod("Алёнка", 100, 115, 250, 450, TypeOfHalva.TahiniBased));
                }

                if (i is CreatorOfKozinak)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 250, 115, 250, 450, TypeOfKozinak.FromSesame));
                    gift.Add(i.FactoryMethod("Алёнка", 100, 115, 250, 450, TypeOfKozinak.FromSunflowerSeeds));
                }

                if (i is CreatorOfMarshmallows)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 150, 115, 250, 450, TypeOfMarshmallows.InChocolate));
                    gift.Add(i.FactoryMethod("Красный пищевик", 100, 115, 250, 450, TypeOfMarshmallows.Vanilla));
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

