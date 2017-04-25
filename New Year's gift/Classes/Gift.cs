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
        private ICollection<Sweet> items;
        public Gift(string name)
        {
            items = new List<Sweet>();
            GiftName = name;
        }
        public void Add(Sweet sweets)
        {
            items.Add(sweets);
        }
        public double GiftWeight()
        {
            return items.Sum(x => x.Weight);
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.Weight).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        public IEnumerable<Sweet> FindCandyBySugar(int min, int max)
        {
            return items.Where(x => (x.SugarPerUnit >= min) && (x.SugarPerUnit <= max)).ToList();
        }
        public ICollection<Sweet> Items
        {
            get { return this.items; }
        }

        public string GiftName
        {
            get;
        }

    }
}
