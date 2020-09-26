using System;

namespace ReverseStringCompression
{
    class StringDecompression
    {
        static string decompress(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                for(int j=i+1; j< str.Length; j++)
                {
                    if(str[i] >= 1 && (str[j] >= 'A' || str[j] <= 'Z' || str[j] >= 'a' || str[j] <= 'z'))
                    {
                        //Console.WriteLine("str[i] is: " + str[i]);
                        //Console.WriteLine("str[j] is: " + str[j]);
                        try
                        {
                            int c = Int32.Parse(str[i].ToString());
                        }
                        catch(Exception e)
                        {
                            Console.Write(e);
                            Environment.Exit(1);
                        }

                        for (int k=1; k<=Int32.Parse(str[i].ToString()); k++)
                        {
                            result += str[j];
                        }
                        i = j;
                        break;
                    }
                    else
                        result += str[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string str;

            Console.Write("Enter a compressed string: ");
            str = Console.ReadLine();

            Console.Write("\n\tDecompressed string is: "+decompress(str));

            Console.ReadLine();
        }
    }
}
