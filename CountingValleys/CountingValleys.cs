using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class CountingValleys
    {
        static void Main(string[] args)
        {
            int v = 0, valley = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            string steps = Console.ReadLine();

            foreach(char step in steps)
            {
                if (step == 'U')
                {
                    if (v == -1)
                    {
                        valley++;
                    }
                    v += 1;
                }
                if (step == 'D')
                    v -= 1;
            }
            Console.Write(valley);
            Console.ReadLine();
        }
    }
}
