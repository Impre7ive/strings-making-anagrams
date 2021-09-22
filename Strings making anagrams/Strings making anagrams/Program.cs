using System;
using System.Linq;

namespace Strings_making_anagrams {
    class Program {
        public static int MakeAnagram(string a, string b) {
            if (a.Length == 0 || b.Length == 0)
                return -1;

            char[] firstStr = a.ToArray<char>();
            char[] secondStr = b.ToArray<char>();
            //Anagram == Intersection
            //In the cycle compare each symbol, when it's found - remove it from target array and continue 
            char[] stringIntersection = firstStr.Intersect<char>(secondStr).ToArray();

            int result = firstStr.Length + secondStr.Length - 2 * stringIntersection.Length;

            //Count number of deletion
            return result > firstStr.Length ? -1 : result;
        }

        static void Main(string[] args) {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int minSymbolsForAnagram = MakeAnagram(a, b);

            Console.WriteLine($"Minimal number of removed symbols for an anagram creation is {minSymbolsForAnagram}");
            Console.ReadLine();
        }
    }
}
