using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class RepeatedString
    {
        static long repeatedString(string s, long n)
        {
            var inSingle = s.Count(x => x == 'a');
            //Console.WriteLine("'a' in single:" + inSingle);

            var full = n / s.Length;
            //Console.WriteLine("Full:" + full);

            var rest = n % s.Length;
            //Console.WriteLine("Rest:" + rest);

            var inRest = s.Substring(0, (int)rest).Count(x => x == 'a');
            //Console.WriteLine("s.Substring(0, (int)rest): " + s.Substring(0, (int)rest));
            //Console.WriteLine("in Rest:" + inRest);

            var result = (inSingle * full) + inRest;

            return result;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.Write(result);
            Console.ReadLine();
        }
    }
}
