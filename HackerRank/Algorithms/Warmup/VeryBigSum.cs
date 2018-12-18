using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Warmup
{
    public class VeryBigSum
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/a-very-big-sum/problem
        /// </summary>
        public static long aVeryBigSum(long[] ar)
        {
            long result = 0;
            foreach (long x in ar)
            {
                result += x;
            }
            return result;
        }
    }
}
