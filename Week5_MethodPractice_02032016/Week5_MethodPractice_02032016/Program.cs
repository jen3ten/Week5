using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_MethodPractice_02032016
{
    class Program
    {
        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }

        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int Subtract(int num1, int num2)
        {
            int difference = num1 - num2;
            return difference;
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        static string ReverseNum(string number)
        {
            StringBuilder reversed = new StringBuilder();
            char[] digits = number.ToCharArray();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                reversed.Append(digits[i]);
            }
            string reversedNum = reversed.ToString();
            return reversedNum;
        }

        static int[] ReturnInt(string[] word)
        {
            int[] intArray = new int[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                intArray[i] = int.Parse(word[i]);
            }

            return intArray;
        }

        static void Main(string[] args)
        {
            SayHi();
            Console.WriteLine();

            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Add(num1, num2);
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine();

            /*Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
            int difference = Subtract(num1, num2);
            Console.WriteLine("The difference is: " + difference);
            Console.WriteLine();

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            SayHello(name);
            Console.WriteLine();*/

            /*Console.Write("Enter a decimal number: ");
            string number = Console.ReadLine();
            string reversed = ReverseNum(number);
            double reversedDecimal = double.Parse(reversed);
            Console.WriteLine(reversedDecimal);
            Console.WriteLine();

            string[] array = { "1", "2", "4", "10" };
            int[] intArray = ReturnInt(array);
            foreach (int digit in intArray)
                Console.Write(digit + ", ");*/
        }
    }
}
