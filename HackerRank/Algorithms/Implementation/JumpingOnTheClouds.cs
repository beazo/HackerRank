using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Implementation
{
    public class JumpingOnTheClouds
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
        /// </summary>
        /// 
        public static int jumpingOnClouds(int[] c)
        {
            var jumps = -1;
            var l = c.Length;
            for (var i = 0; i < l; i++)
            {
                if (i + 2 < l && c[i + 2] == 0)
                    i++;
                jumps++;
            }
            return jumps;
        }
    }
}
