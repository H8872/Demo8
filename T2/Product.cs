﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public Product()
        {
            Name = "Product";
            Price = "0,00";
        }

        public override string ToString()
        {
            return " Product -  Name: " +  Name + " Price: " + Price;
        }
    }
}
