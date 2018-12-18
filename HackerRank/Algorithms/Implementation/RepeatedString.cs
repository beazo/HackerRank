using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms.Implementation
{
    public class RepeatedString
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/repeated-string/problem
        /// </summary>
        public static long repeatedString(string s, long n)
        {
            long result = s.Count(x => x == 'a');
            if (result == 0)
                return 0;
            long cnt = s.Count();
            result *= n / cnt;
            for (var i = 0; i < n % cnt; i++)
            {
                if (s[i] == 'a')
                    result++;
            }
            return result;
        }
    }
}
