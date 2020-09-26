using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass
{
    class HourGlass
    {
        static int result(int[][] arr)
        {
            int row = arr.Length;
            int column = arr[0].Length;
            int max = -64;

            for(int i=0; i<row-2; i++)
            {
                for(int j=0; j<column-2; j++)
                {
                    int curr_max = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i+2][j + 2];
                    max = Math.Max(max, curr_max);
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for(int i=0; i<6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            Console.Write(result(arr));
            Console.ReadLine();
        }
    }
}
