using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Cheese : InvoiceItem
    {
        public Cheese()
        {
            Name = "Cheese";
            Price = 4.60;
            Quantity = 1;
            Total = Quantity * Price;
        }
    }
}
