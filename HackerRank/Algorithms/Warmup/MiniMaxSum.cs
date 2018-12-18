using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    public class MiniMaxSum
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/mini-max-sum/problem
        /// </summary>
        public static void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long sum = arr.Aggregate<int, long>(0, (current, x) => current + x);
            Console.Write(string.Format("{0} {1}", sum - arr[arr.Length - 1], sum - arr[0]));
        }
    }
}
