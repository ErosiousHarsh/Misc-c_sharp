using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //array limit
            int[] a = new int[n+1];
            List<int> con = new List<int>();

            Console.Write("Input\n");

            for(int i=1; i<=n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine()); //taking input
                if(!con.Contains(a[i])) { con.Add(a[i]); }
            }

            Console.Write("\nResult\n");
            for (int i=1; i<=n; i++)
            {
                if (!con.Contains(i) && i != 0) 
                { 
                    Console.Write(i); 
                }    
            }

            Console.ReadLine();
        }
    }
}
