using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Butter : InvoiceItem
    {
        public Butter()
        {
            Name = "Butter";
            Price = 3.50;
            Quantity = 1;
            Total = Quantity * Price;
        }
    }
}
