using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftRotation
{
    class ArrayLeftRotation
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int d = int.Parse(s[1]);

            int[] arr = new int[n];
            arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] r_arr = new int[arr.Length];
            int r_index = d;
            int i = 0;
            while (r_index < arr.Length)
            {
                r_arr[i] = arr[r_index];
                i++;
                r_index++;
            }

            r_index = 0;
            while (r_index < d)
            {
                r_arr[i] = arr[r_index];
                i++;
                r_index++;
            }

            i = 0;
            for (i = 0; i < r_arr.Length; i++)
                Console.Write(r_arr[i] + " ");
            Console.ReadLine();
        }
    }
}
