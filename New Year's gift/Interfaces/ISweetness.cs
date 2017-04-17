using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Interfaces
{
    public interface ISweetness
    {
        double SugarPerUnit { get; }
        double weight { get; }
        string name { get; }
        double CaloriPerUnit { get; }
        double price { get; }
        void TypeOfSweetness();
        //halva
        //kozinaki
        //zephyr
        //pastille
    }
}
