using System;
using System.Text.RegularExpressions;

namespace eRezlife_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2
            string input = "<html><body><div><a></a></div></body></html>";
            //string[] tags = input.Split('>');
            string[] tags = Regex.Split(input, @"(?<=[>])");
            //Counts total amount of tags, adding 1 due to 0 index
            int totalTags = tags.Length + 1;

            //If the opening and closing tags are correct we will have
            //an even amount of tags. Using the modulus operator(%) we 
            //will find the remainder after dividing the total. Any even
            //number is evenly divisible by 2. 
            try
            {
                
                if (totalTags % 2 == 0)
                {
                    // -1 is our zero
                    int closingTagCount = -1;
                    int openingTagCount = -1;

                    foreach (string tag in tags)
                    {
                        // if tag isnt a closing tag
                        if (!tag.Contains("/"))
                        {
                            openingTagCount++;
                            //Print tag
                            Console.WriteLine(tag);
                        }
                        else
                        {
                            closingTagCount++;
                            
                            int findOpeningTag = openingTagCount - closingTagCount;
                            string matchingTag = tags[findOpeningTag];
                            if (tag.Replace("/", String.Empty) == matchingTag)
                            {
                                Console.WriteLine(tag);
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error with input string");
                }
            }
            catch(Exception a)
            {
                Console.WriteLine(a);
            }

            //Problem 3
            string letters = "abcdef";
            //used char array to split string of characters
            var array = letters.ToCharArray();
            //write each line in the array with <>
            foreach (char a in array)
            {
                Console.WriteLine("<" + a + ">");
            }

            //calling function ref keyword indicates that an argument is passed by reference, not by value
            PrintReverse(ref array);

            static void PrintReverse(ref char[] Chars)
            {
                //iterating through the array in reverse
                Console.WriteLine("</" + Chars[Chars.Length - 1] + ">");
                //resize method makes copy of array to keep moving in reverse
                Array.Resize(ref Chars, Chars.Length - 1);
                if (Chars.Length == 0) return;
                PrintReverse(ref Chars);
            }

            //Problem 4
            
        }
    }
}
