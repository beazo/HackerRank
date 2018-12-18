using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Implementation
{
    public class SockMerchant
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/sock-merchant/problem
        /// </summary>
        static int sockMerchant(int n, int[] ar)
        {
            return ar.GroupBy(a => a).Sum(a => a.Count() / 2);
        }
    }
}
