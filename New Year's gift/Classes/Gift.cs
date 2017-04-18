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
        public string GiftName
        {
            get;
           
        }

        public ICollection<ISweetness> items
        {
            get;
           
        }

        public void Add(Sweet sweets)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISweetness> FindCandyBySugar(int min, int max)
        {
            throw new NotImplementedException();
            //Where()
        }

        public double GiftWeight()
        {
                if (items != null)
                { return items.Sum(x => x.Weight); }
                else
                { throw new InvalidOperationException("Conteiner in Salad cannot be null"); }
            //sum()
        }

        public void Sort()
        {
            throw new NotImplementedException();
            // OrderBy();
        }
    }
}
