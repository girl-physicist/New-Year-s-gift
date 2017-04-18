using New_Year_s_gift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Classes
{
    class Gift : IGift
    {
        private ICollection<Sweet> items;
        public Gift()
        {
            items = new List<Sweet>();
        }
        public string GiftName
        {
            get;
        }



        public void Add(Sweet sweets)
        {
            items.Add(sweets);
        }

        public IEnumerable<Sweet> FindCandyBySugar(int min, int max)
        {
           
            //Where()
            return items.Where(x => (x.SugarPerUnit >= min) && (x.SugarPerUnit <= max)).ToList();
        }
        public double GiftWeight()
        {
            if (items != null)
            { return items.Sum(x => x.Weight); }
            else
            { throw new InvalidOperationException("Conteiner in Salad cannot be null"); }
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
        public IEnumerable<Sweet> Items
        {
            get { return this.items; }
        }

        ICollection<Sweet> IGift.items
        {
            get;
        }
    }
}
