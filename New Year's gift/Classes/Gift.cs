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
        private ICollection<ISweetness> items;

        public IEnumerable<ISweetness> Items
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Sweet sweets)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISweetness> FindCandyBySugar(int min, int max)
        {
            throw new NotImplementedException();
        }

        public double GiftWeight()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
