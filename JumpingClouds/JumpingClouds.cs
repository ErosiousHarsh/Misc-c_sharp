using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingClouds
{
    class JumpingClouds
    {
        static int jumpingOnClouds(int[] c)
        {
            int j = 0, i = 0;
            while (i < c.Length-1 )
            {
                if( i+2 == c.Length || c[i+2] == 1)
                {
                    i++;
                    j++;
                }
                else
                {
                    i += 2;
                    j++;
                }
            }
            return j;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int result = jumpingOnClouds(c);

            Console.Write(result);
            Console.ReadLine();
        }
    }
}
