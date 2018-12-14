using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    /// </summary>
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(int n, int[] ar)
        {
            int max = ar.Max();
            return ar.Count(x => x == max);
        }
    }
}
