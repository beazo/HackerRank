using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms.Strings
{
    public class TwoStrings
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/two-strings/problem
        /// </summary>
        public static string twoStrings(string s1, string s2)
        {
            var distS1 = s1.Distinct();
            var distS2 = s2.Distinct();
            return distS1.Intersect(distS2).Any() ? "YES" : "NO";
        }
    }
}
