namespace HackerRank.CrackingTheCodingInterview
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    /// </summary>
    public class ArrayLeftRotation
    {
        public static int[] rotLeft(int[] a, int d)
        {
            var l = a.Length;
            for (int i = 0; i < l; i++)
            {
                a[(i + l - d) % l] = a[i];
            }
            return a;
        }
    }

}

