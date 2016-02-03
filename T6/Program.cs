using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice receipt = new Invoice();
            Console.WriteLine(receipt.PrintInvoice());
        }
    }
}
