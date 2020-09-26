using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearChaosBribe
{
    class NewYearChaosBribe
    {
        static string minimumBribes(int[] q)
        {
            int t = 0;
            for (int c = 0; c < q.Length; c++)
            {
                int o = q[c] - 1;

                int d = o - c;
                if (d > 2)
                {
                    return "Too chaotic";
                }

                if (d <= 0)
                {
                    for (int i = (Math.Max(0, o - 1)); i < c; i++)
                    {
                        int s = q[i] - 1;
                        if (s > o)
                        {
                            t++;
                        }

                    }
                }
            }
            return t.ToString();
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[t];

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                str[i] = minimumBribes(arr);
            }
            foreach (string s in str)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
