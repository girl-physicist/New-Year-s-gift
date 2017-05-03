using New_Year_s_gift.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Interfaces
{

    public interface IGift
    {
        IEnumerable<ISweetness> Items { get; }
        IEnumerable<ISweetness> SortSweetnessByWeight();
        IEnumerable<ISweetness> FindSweetnessBySugar(int min, int max);
        string GiftName { get; }
        void AddSweet(Sweet sweets);
        void RemoveSweet(Sweet sweet);
        int CountOfSweet { get; }
        double GiftWeight { get; }
    }
}
