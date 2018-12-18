using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Warmup
{
    public class SimpleArraySum
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/simple-array-sum/problem
        /// </summary>
        public static int simpleArraySum(int[] ar)
        {
            var result = 0;
            foreach (var x in ar)
                result += x;
            return result;
        }
    }
}
