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

            IGift gift = new Gift("Gift 1",new List<ISweetness>());
            foreach (Creator i in creators)
            {
                if (i is CreatorOfCandy)
                {
                    gift.Add(i.FactoryMethod("M&M", 80, 105, 125, 500, TypeOfCandy.Chocolate,Stuffing.With_Cognac_Stuffing));
                    gift.Add(i.FactoryMethod("ChupaChups", 25, 75, 70, 420, TypeOfCandy.Lollipop,Stuffing.Without_Stuffing));
                }

                if (i is CreatorOfChocolate)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 100, 115, 250, 450, TypeOfChocolate.Milk,DriedFruits.Contains_Prune,75,VariantsOfChocolateProducts.Porous_Chocolate));
                    gift.Add(i.FactoryMethod("Алёнка", 150, 115, 250, 450, TypeOfChocolate.Milk,DriedFruits.Contains_Nut,50, VariantsOfChocolateProducts.Confectionery_Tiles));
                }

                if (i is CreatorOfHalva)
                {
                    gift.Add(i.FactoryMethod("В Шоколаде с орехами", 200, 115, 250, 450, TypeOfHalva.Nut_Butter_Based,WithNuts.With_Crushed_Nut));
                    gift.Add(i.FactoryMethod("халва", 100, 115, 250, 450, TypeOfHalva.Tahini_Based,WithNuts.Without_Nuts));
                    gift.Add(i.FactoryMethod("В Шоколаде ", 200, 115, 250, 450, TypeOfHalva.Nut_Butter_Based, WithNuts.With_Peanuts));
                    gift.Add(i.FactoryMethod(" с орехами", 100, 115, 250, 450, TypeOfHalva.Tahini_Based, WithNuts.With_Whole_Nut));
                }

               

                if (i is CreatorOfMarshmallows)
                {
                    gift.Add(i.FactoryMethod("Alpen Gold", 150, 115, 250, 450, TypeOfMarshmallows.White_Pink,DriedFruits.Contains_Peanut,Thickener.AgarAgar));
                    gift.Add(i.FactoryMethod("Красный пищевик", 100, 115, 250, 450, TypeOfMarshmallows.Vanilla,DriedFruits.Contains_Dried_Apricots,Thickener.Gelatin));
                }
                
            }

            gift.SortSweetnessByWeight();
            gift.ShowItems();
            

        }
    }
}

