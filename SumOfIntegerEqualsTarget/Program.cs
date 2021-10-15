using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntegerEqualsTarget
{
    /// <summary>
    /// given an array of int numbers and an int target
    /// return index of the two numbers such that they add up to target
    /// use one loop
    /// 
    /// eg: input 2,7,11,15
    /// target = 17
    /// output: 1,4 or 4,1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[4] { 2, 15, 7, 11 };
            int target = 9;
            int complement = 0;

            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < intArray.Length; i++)
            {
                complement = target - intArray[i];
                if (myDict.ContainsKey(intArray[i]))
                {
                    Console.Write(myDict[intArray[i]]);   //the number 
                    Console.WriteLine(" , " + i);         //the index
                }
                else
                {
                    myDict.Add(complement, i);
                }
            }
            Console.ReadLine();

        }
    }
}
//solution:
//for loop save the numbers
//that number minus the target 
//save that number in the dictionary. 
// in the next loop, the next number in array is in spotligight.
//first; find the complement. 
//second; check if this number is in the dictionary
//ie; check if its a complement of any the previous numbers in the array 
//key= comlement number 
//value= index in array