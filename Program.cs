using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TittleCaseFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: Empty input");
                return;
            }
            string result = CapitalizeSentence(input);
            Console.WriteLine($"Result: {result}");
        }
        static string CapitalizeSentence(string sentence)
        {
            StringBuilder result = new StringBuilder();
            bool newWord = true; // Flag to track start of new word

            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    // Handle space - next character starts new word
                    result.Append(c);
                    newWord = true;
                }
                else if (newWord)
                {
                    // Capitalize first letter of word
                    if (c >= 'a' && c <= 'z')
                    {
                        result.Append((char)(c - 32)); // Convert to uppercase
                    }
                    else
                    {
                        result.Append(c); // Already uppercase
                    }
                    newWord = false;
                }
                else
                {
                    // Lowercase remaining letters
                    if (c >= 'A' && c <= 'Z')
                    {
                        result.Append((char)(c + 32)); // Convert to lowercase
                    }
                    else
                    {
                        result.Append(c); // Already lowercase
                    }
                }
            }
            return result.ToString();
        }
    }
}
