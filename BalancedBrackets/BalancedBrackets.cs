using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static string brackets(string s)
        {
            Stack<char> br = new Stack<char>();

            foreach(char c in s)
            {
                if (c == '{' || c == '(' || c == '[')
                    br.Push(c);
                else
                {
                    if (br.Count() == 0)
                    {
                        return "NO";
                    }
                    else if (c == '}')
                    {
                        if (br.Pop() != '{')
                            return "NO";
                    }
                    else if (c == ')')
                    {
                        if (br.Pop() != '(')
                            return "NO";
                    }
                    else if (c == ']')
                    {
                        if (br.Pop() != '[')
                            return "NO";
                    }

                }
            }
            if (br.Count() == 0)
                return "YES";
            else
                return "NO";
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string ns = "";

            for(int i=0; i<n; i++)
            {
                string s = Console.ReadLine();

                ns +=brackets(s)+ " ";
            }
            foreach(string s in ns.Split(' '))
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
