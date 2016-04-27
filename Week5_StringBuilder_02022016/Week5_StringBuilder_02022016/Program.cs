using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_StringBuilder_02022016
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use StringBuilder class to concatenate string of numbers, i
            StringBuilder name = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                name.Append(i);
            }
            Console.WriteLine(name.ToString());
            Console.WriteLine();

            //Measure the amount of time it takes to append a string with StringBuilder
            Console.WriteLine(DateTime.Now);
            StringBuilder numSB = new StringBuilder();
            numSB.Append("Build with StringBuilder!");
            for (int i = 0; i < 200000; i ++)
            {
                numSB.Append(i);
            }
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();

            //Measure the amount of time it takes to append with concatenation
            /*Console.WriteLine(DateTime.Now);
            string numStr = "";
            numStr+="Build with concatenation";
            for (int i = 0; i < 200000; i++)
            {
                numStr += i;
            }
            Console.WriteLine(DateTime.Now);*/

            string text = "EM edit";
            Console.WriteLine(text);
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
            string caps = ExtractCapitals(text);
            Console.WriteLine(caps);
            Console.WriteLine();
        }

        static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }

        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
    }
}
