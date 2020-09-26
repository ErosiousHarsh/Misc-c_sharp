﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOfSocks
{
    class PairOfSocks
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(A);
            int ans = 0;
            for (int i = 1; i < n; i++)
            {
                if (A[i] == A[i - 1]) { ans++; i++; }
            }
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
