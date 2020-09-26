using System;
using System.Collections.Generic;
using System.Linq;

namespace AllPossibleCombinations
{
    class AllPossibleCombinations
    {

        static List<String> db = new List<String>();
        static int c = 0;
        private static void permute(String str, int l, int r) //permute
        {
            if (l == r)
            {
                if (!db.Any())
                {
                    db.Add(str);
                    c += 1;
                }
                else
                {
                    if (!db.Contains(str))
                    {
                        db.Add(str);
                        c += 1;
                    }
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        public static String swap(String a,
                              int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        static void Main(string[] args)
        {

            string str;

            Console.Write("Enter a string: ");
            str = Console.ReadLine();

            permute(str, 0, str.Length - 1);

            Console.WriteLine("\nTotal permutations: " + c);
            Console.Write("\n");
            int x = 1;

            foreach (String i in db)
            {
                Console.WriteLine(x + ":" + "\t" + i);
                x++;
            }

            Console.ReadLine();
        }
    }
}
