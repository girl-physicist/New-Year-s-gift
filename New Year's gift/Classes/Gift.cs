using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace New_Year_s_gift.Classes
{
    class Gift : IGift
    {
        private ICollection<ISweetness> items;
        public IEnumerable<ISweetness> Items
        {
            get{ return this.items; }
        }
        public string GiftName
        {
            get;
        }
        public Gift(string name,ICollection<ISweetness> items)
        {
           this.items =items ;
            GiftName = name;
        }
        public void AddSweet(Sweet sweet)
        {
            items.Add(sweet);
        }
        public void RemoveSweet(Sweet sweet)
        {
            items.Remove(sweet);
        }
        public int GetCountOfSweet()
        {
           return items.Count();
        }
        public double GiftWeight()
        {
            return items.Sum(x => x.Weight);
        }

        public IEnumerable<ISweetness> SortSweetnessByWeight()
        {
            var temp = items.OrderBy(x => x.Weight).ToArray();
            return temp;
        }
        public IEnumerable<ISweetness> FindSweetnessBySugar(int min, int max)
        {
            return items.Where(x => (x.SugarPerUnit >= min) && (x.SugarPerUnit <= max)).ToList();
        }
    }
}
