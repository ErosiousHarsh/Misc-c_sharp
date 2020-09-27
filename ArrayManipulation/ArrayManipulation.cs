using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/crush/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays

namespace ArrayManipulation
{
    class ArrayManipulation
    {
        static long arrayManipulation(int n, int[][] queries)
        {
            long max = 1, ub, lb, k;
            long[] arr = new long[n + 1];

            for (int r = 0; r < queries.Length; r++)
            {
                lb = queries[r][0];
                ub = queries[r][1];
                k = queries[r][2];
                arr[lb - 1] += k;
                arr[ub] -= k;
            }

            for (int r = 0; r < n - 1; r++)
            {
                arr[r + 1] += arr[r];
                max = Math.Max(arr[r + 1], max);
            }
            return max;
        }
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            int[][] arr = new int[m][];

            for (int i = 0; i < m; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            Console.Write(arrayManipulation(n, arr));
            Console.ReadLine();
        }
    }
}
