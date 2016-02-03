using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Dice
    {
        private Random dice = new Random();
        public int Throw()
        {
            int value = dice.Next(6) + 1;
            return value;
        }
    }
}
