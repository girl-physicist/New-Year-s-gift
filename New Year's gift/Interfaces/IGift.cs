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
        IEnumerable<Sweet> Items { get; }
        string GiftName { get; }
        void Add(Sweet sweets);
        double GiftWeight();
        void Sort();
        IEnumerable<Sweet> FindCandyBySugar(int min, int max);
    }
}
