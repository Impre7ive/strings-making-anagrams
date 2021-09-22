using System;
using System.Linq;

namespace Strings_making_anagrams {
    class Program {
        public static char[] ExtractAnagram(string a, string b) {
            char[] firstStr = a.ToArray<char>();
            char[] secondStr = b.ToArray<char>();
            //Anagram == Intersection
            //In the cycle compare each symbol, when it's found - remove it from target array and continue 
            return firstStr.Intersect<char>(secondStr).ToArray();
        }

        public static int RetrieveMinimalDeletionToGetAnagram(char[] anagram, string a, string b) {
            if (anagram.Length == 0)
                return -1;

            int result = a.Length + b.Length - 2 * anagram.Length;

            //Count number of deletion
            return (result > a.Length && result > b.Length) ? -1 : result;
        }

        static void Main(string[] args) {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            char[] anagram = ExtractAnagram(a, b);

            int minSymbolsForAnagram = RetrieveMinimalDeletionToGetAnagram(anagram, a, b);

            Console.WriteLine($"Minimal number of removed symbols for an anagram creation is {minSymbolsForAnagram}.");
            Console.ReadLine();
        }
    }
}
