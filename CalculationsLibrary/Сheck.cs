using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLibrary
{
    public static class Сheck
    {
        public static double PriseOfProduct(double count, double Prise)
        { if (count%1!=0)
            { return 0; }
            if (count<0 || Prise<0)
            { return 0; }
            return count*Prise;
        }
    }
}
