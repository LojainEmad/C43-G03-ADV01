using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignment1
{
   
    internal class Range<T> : IComparable<Range<T>> where T : IComparable<T>
    {

        public T Max { get; set; }
        public T Min { get; set; }
        public Range(T min, T max)
        {

            Min = min;
            Max = max;
        }
        public bool IsInRange(T? value)
        {
            if (value is null) return false;
            bool b_min = value.CompareTo(Min) >= 0;
            bool b_max = value.CompareTo(Max) <= 0;
            return b_min && b_max;
        }
        public T GetLength()
        {
            dynamic min = Min;
            dynamic max = Max;
            return max - min;
        }
        public int CompareTo(Range<T> other)
        {

            int compare = Min.CompareTo(other.Min);
            if (compare != 0)
                return compare;
            return Max.CompareTo(other.Max);
        }
        public override string ToString()
        {
            return $"Range({Min}, {Max})";
        }
    }

}