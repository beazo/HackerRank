using System;

namespace HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/big-sorting/problem
    /// </summary>
    public class BigSorting
    {
        public static string[] bigSorting(string[] unsorted)
        {
            Array.Sort(unsorted, (a, b) =>
            {
                if (a.Length == b.Length)
                    return string.Compare(a, b, StringComparison.Ordinal);
                return a.Length - b.Length;
            });
            return unsorted;
        }
    }
}
