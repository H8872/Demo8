using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

        public override string ToString()
        {
            return String.Format("\n {0}  {1:F2}e  {2} pieces  {3}e total\n", Name, Price, Quantity, Total);
            //return " " + Name + "  " + Price + "e  " + Quantity + " pieces  " + Total + "e total";
        }
    }
}
