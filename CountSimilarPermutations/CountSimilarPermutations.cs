using System;
using System.Collections.Generic;
using System.Linq;

namespace AllPossibleCombinations
{
    class CountSimilarPermutations
    {

        static List<String> db = new List<String>();
        private static void permute(String str, int l, int r) //permute
        {
            if (l == r)
            {
                if (!db.Any())
                {
                    //Console.WriteLine("p: "+str);
                    db.Add(str);
                }
                else
                {
                    if (!db.Contains(str))
                    {
                        //Console.WriteLine("p2: " + str);
                        db.Add(str);
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
            List<String> check = new List<String>();

            int n,x=0;
            
            Console.Write("Enter limit (1/2/3..): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            string[] str = new string[n];

            for (int i=0; i<n; i++)
            {
                Console.Write("word["+i+"]: ");
                str[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                permute(str[i], 0, str[i].Length - 1);

                db.RemoveAt(0);
                foreach(String s in db)
                {
                    foreach(String s1 in str)
                    {
                        if (s1.Equals(s)) {
                            if (!check.Contains(s1)) {
                                //Console.WriteLine(s1 + " matched with " + s);
                                x++;
                                check.Add(s1);
                            }
                        }
                    }
                }
                db.Clear();
            }

            Console.WriteLine("\nTotal matches: " + x/2);
            Console.Write("\n");
            
            Console.ReadLine();
        }
    }
}
