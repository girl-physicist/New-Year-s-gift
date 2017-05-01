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
            Candy candy1 = new Candy("Сhupa Chups XXL 4D", 29, 0.65, 91, 370, TypeOfCandy.Lollipop, Stuffing.Without_Stuffing);
            Candy candy2 = new Candy("Аэрофлотские", 150, 1.95, 64.3, 483, TypeOfCandy.Chocolate, Stuffing.With_Waffle_Сrumb_Stuffing);

            Chocolate choco1 = new Chocolate("Спартак", 75, 1.45, 48, 540, TypeOfChocolate.Dark, DriedFruits.Contains_Nut, 59, VariantsOfChocolateProducts.Porous_Chocolate);
            Chocolate choco2 = new Chocolate("Любимая Алёнка", 200, 2.99, 51.5, 550, TypeOfChocolate.Milk, DriedFruits.Without_Dried_Fruits, 40, VariantsOfChocolateProducts.Chocolate);

            Halva halva1 = new Halva("Бобруйская", 60,0.55, 45, 530, TypeOfHalva.Sunflower_Based, WithNuts.Without_Nuts);
            Halva halva2 = new Halva("Азовская", 250, 2.20, 29.1, 545, TypeOfHalva.Peanut_Butter_Based, WithNuts.Without_Nuts);

            Marshmallows Marshmallows1 = new Marshmallows("Удалить", 150, 115, 250, 450, TypeOfMarshmallows.White_Pink, DriedFruits.Contains_Peanut, Thickener.AgarAgar);
            Marshmallows Marshmallows2 = new Marshmallows("Первый Бобруйский", 250, 2.19, 81, 310, TypeOfMarshmallows.White_Pink, DriedFruits.Contains_Candied_Fruit, Thickener.AgarAgar);
            Marshmallows Marshmallows3 = new Marshmallows("Чаровей", 80, 0.89, 74, 340, TypeOfMarshmallows.Vanilla, DriedFruits.Without_Dried_Fruits, Thickener.Pectin);

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

