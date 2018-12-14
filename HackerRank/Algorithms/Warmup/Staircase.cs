using System;

namespace HackerRank.Algorithms.Warmup
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/staircase/problem
    /// </summary>
    public class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var result = new string('#', i + 1);
                Console.WriteLine(result.PadLeft(n, ' '));
            }
        }
    }
}
