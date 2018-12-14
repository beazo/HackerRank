using System.Linq;

namespace HackerRank.Algorithms.Implementation
{
    public class HurdleRace
    {
        /// <summary>
        /// This is the solution only, for implementation and test cases view the below URL
        /// https://www.hackerrank.com/challenges/the-hurdle-race/problem
        /// </summary>
        public static int hurdleRace(int k, int[] height)
        {
            var potions = height.Max() - k;
            if (potions < 0)
                potions = 0;
            return potions;

        }
    }
}
