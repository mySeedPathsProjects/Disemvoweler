using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the Disemvoweler function
            Disemvoweler("Nickleback is my favorite band.  Their songwriting can't be beat.");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby.  I make the functions and I make the calls.");

            // keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Removes all spaces, vowels, and special characters from text.  Prints the original text, the text with all things removed, and the vowels removed (in order).  
        /// </summary>
        /// <param name="input">string of text</param>
        /// <returns>the disemvoweled text</returns>
        public static string Disemvoweler(string input)
        {
            //create an empty string to hold the text with all spaces, vowels, and special characters removed.  and a string to hold all vowels that were removed, in order.
            string disEmvoweledText = string.Empty;
            string orderedVowels = string.Empty;

            //find all consonants and vowels and add each to respective new string
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiou".Contains(input[i].ToString().ToLower()))
                {
                    orderedVowels += input[i];
                }else if ("bcdfghjklmnpqrstvwxyz".Contains(input[i].ToString().ToLower()))
                {
                    disEmvoweledText += input[i];
                }
            }

            // Write out the various string results
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + disEmvoweledText);
            Console.WriteLine("Vowels Removed: " + orderedVowels); 
            // Return the Disemvoweled string as well for testing
            return disEmvoweledText;
        }
    }
}
