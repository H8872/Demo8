using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCalcs acalc = new ArrayCalcs();
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double sum = acalc.Sum(array);
            double ave = acalc.Average(array);
            double max = acalc.Max(array);
            double min = acalc.Min(array);
            Console.WriteLine("Array\n - Max: " + max + "\n - Min: " + min + "\n - Average: " + ave + "\n - Sum: " + sum);
        }
    }
}
