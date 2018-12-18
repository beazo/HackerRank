using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.ConstructiveAlgorithms
{
    public class NewYearChaos
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/new-year-chaos/problem
        /// </summary>
        static void minimumBribes(int[] q)
        {
            var cnt = 0;
            for (var i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                var max = 0 > q[i] - 2 ? 0 : q[i] - 2;
                for (var j = max; j < i; j++)
                    if (q[j] > q[i])
                        cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
