using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdLikeToBuyAVowel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please provide a word or sentance: ");
            string str = Console.ReadLine();
            Console.WriteLine("This word/sentence has " + CountVowels(str) + " vowels");
        }

        static int CountVowels(string str)
        {
            string vowels = "aeiouAEIOU";
            int vowelCount = 0;
            for(int x = 0; x < str.Length; x++)
            {
                if (vowels.Contains(str[x]))
                    vowelCount += 1;
            }
            return vowelCount;
        }
    }
}
