using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Invoice
    {
        string Customer = "Tuomas Veturi", Total = "butt";
        double dTotal;
        public List<InvoiceItem> Receipt = new List<InvoiceItem>();

        Milk milk = new Milk();
        Butter butter = new Butter();
        Cheese cheese = new Cheese();

        public string PrintInvoice()
        {
            dTotal = milk.Total + butter.Total + cheese.Total;
            Total = dTotal.ToString();
            string op = String.Format("Customer {0}'s invoice\n================================" + milk.ToString() + butter.ToString() + cheese.ToString() + "================================\nTotal: {1:F2} euros", Customer, Total);
            return op;
        }
    }
}
