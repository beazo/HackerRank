using System;
using System.Linq;

namespace HackerRank.CrackingTheCodingInterview
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
    /// </summary>
    public class StringMakingAnagrams
    {
        public static int makeAnagram(string a, string b)
        {
            var alphabet = new int[26];
            foreach (var c in a)
                alphabet[c - 'a']++;

            foreach (var c in b)
                alphabet[c - 'a']--;

            return alphabet.Sum(Math.Abs);
        }
    }
}
