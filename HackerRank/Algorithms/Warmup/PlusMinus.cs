using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms.Warmup
{
    public class PlusMinus
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/plus-minus/problem
        /// </summary>
        public static void plusMinus(int[] arr)
        {
            double neg = 0, zero = 0, pos = 0;
            foreach (var x in arr)
            {
                if (x < 0)
                    neg++;
                else if (x > 0)
                    pos++;
                else
                    zero++;
            }
            Console.WriteLine(Math.Round(pos / arr.Length, 6).ToString("0.000000"));
            Console.WriteLine(Math.Round(neg / arr.Length, 6).ToString("0.000000"));
            Console.WriteLine(Math.Round(zero / arr.Length, 6).ToString("0.000000"));
        }
    }
}
