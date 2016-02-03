using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    public class ArrayCalcs
    {
        public double Sum(double[] array)
        {
            double sum = array.Sum();
            return sum;
        }
        public double Average(double[] array)
        {
            double ave = array.Average();
            return ave;
        }
        public double Min(double[] array)
        {
            double min = array.Min();
            return min;
        }
        public double Max(double[] array)
        {
            double max = array.Max();
            return max;
        }
    }
}
