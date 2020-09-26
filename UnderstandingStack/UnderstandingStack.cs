using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStack
{
    class UnderstandingStack
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();

            Console.Write("For push: 1\nFor pop: 2\nExit: 3\n");
            
            while (true)
            {
                Console.Write("\nEnter: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (n == 1)
                {
                    while (true)
                    {
                        Console.Write("Enter anything: ");
                        string s = Console.ReadLine();
                        if (s.Length != 0)
                        {
                            st.Push(s);
                            Console.WriteLine("successfully pushed.\n");
                            Console.Write("{ ");
                            foreach (string s1 in st)
                                Console.Write(s1+ " ");
                            Console.Write(" }");
                            Console.WriteLine();
                            break;
                        }
                    }
                }
                else if (n == 2)
                {
                    if (st.Count() == 0)
                    {
                        Console.WriteLine("Stack Empty."); 
                        continue;
                    }
                    string s = st.Pop();
                    Console.WriteLine("'" + s + "' popped\n");
                    Console.Write("{ ");
                    foreach (string s1 in st)
                        Console.Write(s1 + " ");
                    Console.Write(" }");
                    Console.WriteLine();
                }
                else
                    break;
            }

            Console.ReadLine();
        }
    }
}
