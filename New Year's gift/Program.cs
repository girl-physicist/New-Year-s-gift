using New_Year_s_gift.Classes;
using New_Year_s_gift.Enum;
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
            IGift gift = new Gift("Gift 1", new List<ISweetness>());
            Candy candy1 = new Candy("ChupaChups", 25, 75, 70, 420, TypeOfCandy.Lollipop, Stuffing.Without_Stuffing);
            Candy candy2 = new Candy("M&M", 80, 105, 125, 500, TypeOfCandy.Chocolate, Stuffing.With_Cognac_Stuffing);

            Chocolate choco1 = new Chocolate("Alpen Gold", 100, 115, 250, 450, TypeOfChocolate.Milk, DriedFruits.Contains_Prune, 75, VariantsOfChocolateProducts.Porous_Chocolate);
            Chocolate choco2 = new Chocolate("Алёнка", 150, 115, 250, 450, TypeOfChocolate.Milk, DriedFruits.Contains_Nut, 50, VariantsOfChocolateProducts.Confectionery_Tiles);

            Halva halva1 = new Halva("В Шоколаде с орехами", 200, 115, 250, 450, TypeOfHalva.Nut_Butter_Based, WithNuts.With_Crushed_Nut);
            Halva halva2 = new Halva("халва", 100, 115, 250, 450, TypeOfHalva.Tahini_Based, WithNuts.Without_Nuts);

            Marshmallows Marshmallows1 = new Marshmallows("Удалить", 150, 115, 250, 450, TypeOfMarshmallows.White_Pink, DriedFruits.Contains_Peanut, Thickener.AgarAgar);
            Marshmallows Marshmallows2 = new Marshmallows("Красный пищевик", 150, 115, 250, 450, TypeOfMarshmallows.White_Pink, DriedFruits.Contains_Peanut, Thickener.AgarAgar);
            Marshmallows Marshmallows3 = new Marshmallows("Красный пищевик", 100, 115, 250, 450, TypeOfMarshmallows.Vanilla, DriedFruits.Contains_Dried_Apricots, Thickener.Gelatin);


            gift.AddSweet(candy1);
            gift.AddSweet(candy2);
            gift.AddSweet(choco1);
            gift.AddSweet(choco2);
            gift.AddSweet(halva1);
            gift.AddSweet(halva2);
            gift.AddSweet(Marshmallows1);
            gift.AddSweet(Marshmallows2);
            gift.AddSweet(Marshmallows3);

            gift.RemoveSweet(Marshmallows1);
            
            gift.SortSweetnessByWeight();
            gift.ShowItems();
        }
    }
}

