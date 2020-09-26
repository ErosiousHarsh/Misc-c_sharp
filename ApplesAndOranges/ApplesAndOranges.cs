using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndOranges
{
    class ApplesAndOranges
    {
        static void Main(string[] args)
        {
            int c = 0;
            string[] st = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(st[0]);
            int t = Convert.ToInt32(st[1]);
            int[] anb = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] mnn = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            long[] distanceMfromA = new long[mnn[0] + 1];
            distanceMfromA = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            long[] distanceNfromB = new long[mnn[1] + 1];
            distanceNfromB = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            for (int i = 0; i < distanceMfromA.Length; i++) { if(distanceMfromA[i] + anb[0] >= s && distanceMfromA[i] + anb[0] <= t) c++; }
            Console.WriteLine(c);
            c = 0;
            for (int i = 0; i < distanceNfromB.Length; i++) { if (distanceNfromB[i] + anb[1] >= s && distanceNfromB[i] + anb[1] <= t) c++; }
            Console.Write(c);
        }
    }
}
