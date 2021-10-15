using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    /// <summary>
    /// reverse word in a sentence without chnaging the original position of words
    /// withoutout using string BCL methods
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("input sentence");
            string sentence = Console.ReadLine();
            Method1(sentence);

            string output = string.Empty;
            List<string> list = new List<string>();
            for (int i = sentence.Length; i >= 0 ; i--)
            {
                if(sentence[i] == ' ')
                {
                    list.Add(output);
                    string temp = " ";
                    list.Add(temp);
                    output = string.Empty;
                }
                else if(i == 0)
                {
                    output += sentence[i];
                    list.Add(output);
                }
                else
                {
                    output += sentence[i];
                }
            }


            Console.ReadLine();

        }

        public static void Method1(string sentence)
        {
            string[] wordArray = sentence.Split(' ');  //this is BCL method

            string reverseWord = string.Empty;
            foreach (string word in wordArray)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord += word[i];
                }

            }
            Console.WriteLine(reverseWord);
        }
    }
}

/* METHOD 1
 * use string builder
 * 
 * METHOD 2
 * read charcters from reverse
 * add the last character into a string
 * when encounter a space, add that string into a list
 */
