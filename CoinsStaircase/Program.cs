using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinsStaircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = Convert.ToInt32(Console.ReadLine());
            int floor = 1;
            int o = 0;

            for(int i = 1; i <= total; i++)
            {
                if(floor <= total)
                {
                    o = i;
                    total -= i;
                    floor += 1;
                }
            }

            Console.Write("Final floor: "+o);
            Console.ReadLine();
        }
    }
}
