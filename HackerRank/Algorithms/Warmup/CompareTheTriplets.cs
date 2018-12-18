using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Warmup
{
    public class CompareTheTriplets
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/compare-the-triplets/problem
        /// </summary>
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int[] result = new int[2];
            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    result[0]++;
                else if (a[i] < b[i])
                    result[1]++;
            }
            return result.ToList();
        }
    }
}
