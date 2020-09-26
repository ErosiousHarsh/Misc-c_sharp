using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sf = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int[] G = new int[n];
            for(int i=0; i<n; i++) { G[i] = int.Parse(Console.ReadLine()); }
            Console.Write("\n\n");
            foreach(int m in G)
            {
                //Console.WriteLine("m={0}, Math.Ciel(m/5*5)={1}",m, Math.Ceiling((float)m / 5) * 5);
                if(Math.Ceiling((float)m/5)*5 - m < 3) 
                {
                    if (Math.Ceiling((float)m / 5)*5 >= 40) 
                    { 
                        Console.WriteLine(Math.Ceiling((float)m / 5) * 5); 
                    } 
                    else Console.WriteLine(m); 
                }
                else if(Math.Ceiling((float)m / 5) * 5 - m == 3) 
                { 
                    Console.WriteLine(m); 
                }
                else Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
