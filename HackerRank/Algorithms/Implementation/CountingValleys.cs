using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Implementation
{
    public class CountingValleys
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/counting-valleys/problem
        /// </summary>
        static int countingValleys(int n, string s)
        {
            var seaLevel = 0;
            var result = 0;
            bool valley = false;
            foreach (var x in s)
            {
                if (x == 'U')
                {
                    if (seaLevel == 0)
                        valley = false;
                    seaLevel++;
                }
                else if (x == 'D')
                {
                    if (seaLevel == 0)
                        valley = true;
                    seaLevel--;
                }
                if (seaLevel == 0 && valley)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
