using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoKangaroos
{
    class Program
    {
        static string jump(int x1, int v1, int x2, int v2)
        {
            string o;
            for (int i = x1;; i += v1)
            {
                for (int j = x2;; j += v2)
                {
                    if (i == j)
                    {
                        o = "YES";
                        break;
                    }
                    else if((x1 > x2 && v1 > v2) || (x2 > x1 && v2 > v1)) { return "NO"; }
                    else
                    {
                        continue;
                    }
                }
                break;
            }
            if (o == null)
                return "NO";

        }
        static void Main(string[] args)
        {
            string[] xv1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(xv1[0]);
            int v1 = Convert.ToInt32(xv1[1]);
            int x2 = Convert.ToInt32(xv1[2]);
            int v2 = Convert.ToInt32(xv1[3]);

            Console.Write(jump(x1, v1, x2, v2));

            Console.ReadLine();
        }
    }
}
