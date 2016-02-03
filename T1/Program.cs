using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0;
            int loop, i = 0, value;
            int d1 = 0, d2 = 0, d3 = 0, d4 = 0, d5 = 0, d6 = 0;
            Dice dice = new Dice();

            Console.Write("Kuinka monta kertaa noppaa heitetään? > ");
            string stuff = Console.ReadLine();
            int.TryParse(stuff, out loop);

            do
            {  
                value = dice.Throw();
                average = average + value;
                switch (value)
                {
                    case 1: d1++;
                        break;

                    case 2: d2++;
                        break;

                    case 3: d3++;
                        break;

                    case 4: d4++;
                        break;

                    case 5: d5++;
                        break;

                    case 6: d6++;
                        break;
                }
                i++;
            } while (i < loop);

            average = average / loop;

            Console.WriteLine("Number of throws: " + loop + "\nAverage: " + average + "\n  - Dice 1: " + d1 + "\n  - Dice 2: " + d2 + "\n  - Dice 3: " + d3 + "\n  - Dice 4: " + d4);
            Console.WriteLine("  - Dice 5: " + d5 + "\n  - Dice 6: " + d6);
        }
    }
}
