using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBracketsMatch
{
    /// <summary>
    /// given a string with only ( ) { } [ ] as characters
    /// Determine if string is valid
    /// - open bracket must be closed by same type of bracket
    /// - open bracket must be closed in the same order
    /// [()] valid
    /// [{()}] valid
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();

            Program pObj = new Program();
            bool result = pObj.Checker(str);

            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }

        public bool Checker(string str)
        {
            Stack<char> myStack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '{' || str[i] == '[')
                {
                    myStack.Push(str[i]);
                }
                else
                {
                    var temp = myStack.Pop();
                    if (str[i] == ')' && temp == '(')
                    {
                        continue;
                    }
                    else if (str[i] == '}' && temp == '{')
                    {
                        continue;
                    }
                    else if (str[i] == ']' && temp == '[')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("invalid Sting");
                        Console.ReadLine();
                        return false;
                    }
                }
            }
            Console.WriteLine("valid string");
            return true;
            Console.ReadLine();
        }
    }
}
