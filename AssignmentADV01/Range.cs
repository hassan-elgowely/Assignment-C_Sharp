using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV01
{
    internal class Range<T> where T : IComparable
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T _min , T _max)
        {
            Min = _min;
            Max = _max;
        }

        public bool IsInRange(T check)
        {
            if (check != null)
            {
                return (check.CompareTo(Min) == 1) && (Max.CompareTo(check) == 1);
            }
            return false;
        }

        public dynamic Length()
        {
            
            return (dynamic)Max - (dynamic)Min;
        }
    }
}
