using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_LostTeeth_02042016
{
    class Program
    {
        //LostTeeth Method
        //Ask user for a year in the future (check to make sure input > 2016)
        //Calculate number of years passed
        //Formula for predicted loss of teeth is 1 tooth per every 3 years
        //Output number of teeth to the console as a whole number
        //If there is a remainder (mod), there is an additional tooth that is wiggly

        //Call LostTeeth with year as parameter

        static void LostTeeth (int year)
        {
            int yearsPassed = year - 2016;
            int numTeeth = yearsPassed / 3;
            bool wiggly = false;
            if (numTeeth % 3 > 0)
                wiggly == true;

        }


        static void Main(string[] args)
        {
        }
    }
}
