using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_MethodPractice_02042016
{
    class Program
    {
        static void NameAgeState (string name, string age, string state)
        {
            Console.WriteLine($"Hey {name}! I can't believe you are {age} years old.  That's why you live in {state}.");
        }

        static void Main(string[] args)
        {
            //NameAgeState Method
            //Take information and prints information into a current sentence
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("What is you age? ");
            string age = Console.ReadLine();
            Console.Write("What state are you from? ");
            string state = Console.ReadLine();
            NameAgeState(name, age, state);

        }
    }
}
