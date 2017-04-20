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
        ICollection<Sweet> Items { get; }
        string GiftName { get; }
        void Add(Sweet sweets);
        double GiftWeight();
        //void ShowItems(); 
        void Sort();
        //void FindCandyBySugar(int min, int max);
        IEnumerable<Sweet> FindCandyBySugar(int min, int max);
    }
}
