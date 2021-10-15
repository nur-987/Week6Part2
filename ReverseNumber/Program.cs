using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    /// <summary>
    /// reverse a number without converting it to string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number?");
            int num = Int32.Parse(Console.ReadLine());
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10; //getting the last number moving it to the 1st position
                reverse = (reverse * 10) + remainder; //multiply it by 10 so that isntead of one number we have 2 numbers
                                                       // plus the next number as a ones
                num = num / 10;                 //continue to divide and that the remiander
            }

            Console.WriteLine("the reverse num {0}", reverse); 
            Console.ReadLine();
            
        }

    }

   /* 462 divide by 10 = 46 remainder 2
    * result = 2 
    * 2*10 = 20
    * result = 20
    * 46 divide by 10 = 4 remainder 6
    * result = 20 + 6 = 26
    * 26*10 = 260
    * 4 divide by 10 = 0 remainder 4
    * result = 260 + 4
    * number = 0 
    * while loop will stop
    */
}
