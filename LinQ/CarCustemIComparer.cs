using LinqForCSharpDevelopers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class CarCustemIComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            int result = 0;
            if (x is null && y is null) return 0;
            if (x?.MaxSpeed > y?.MaxSpeed)
            {
                result = 1;
            }
            else if (x?.MaxSpeed < y?.MaxSpeed)
            {
                result = -1;
            }
            return result;
        }

    }
}
