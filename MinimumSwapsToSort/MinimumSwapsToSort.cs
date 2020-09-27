using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/minimum-swaps-2/problem

namespace MinimumSwapsToSort
{
    class MinimumSwapsToSort
    {
        static int minSwaps(int[] arr)
        {
            int k = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] != i + 1)
                {
                    while (arr[i] != i + 1)
                    {
                        int temp = arr[arr[i] - 1];
                        arr[arr[i] - 1] = arr[i];
                        arr[i] = temp;
                        k++;
                        /*Console.WriteLine();
                        foreach (int a in arr)
                            Console.Write(a + " ");
                        Console.WriteLine();*/
                    }
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[n];
            arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write(minSwaps(arr));

            Console.ReadLine();
        }
    }
}
