using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Milk : InvoiceItem
    {
        public Milk()
        {
            Name = "Milk";
            Price = 3.00;
            Quantity = 2;
            Total = Quantity * Price;
        }
    }
}
