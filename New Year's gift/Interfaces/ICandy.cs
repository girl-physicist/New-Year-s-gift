using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift.Interfaces
{
    interface ICandy:ISweetness
    {
        TypeOfCandy TypeOfCandy { get; }
    }
}
