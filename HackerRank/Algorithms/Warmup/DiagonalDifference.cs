using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Warmup
{
    public class DiagonalDifference
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/diagonal-difference/problem
        /// </summary>
        public static int diagonalDifference(int[][] arr)
        {
            var total = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                total += arr[i][i];
                total -= arr[i][(arr.Length - 1) - i];
            }
            return Math.Abs(total);
        }
    }
}
