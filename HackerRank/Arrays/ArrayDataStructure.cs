namespace HackerRank.Arrays
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/arrays-ds/problem
    /// </summary>
    public class ArrayDataStructure
    {
        public static int[] reverseArray(int[] a)
        {
            var result = new int[a.Length];
            for (int i = a.Length - 1, j = 0; i >= 0; i--, j++)
                result[j] = a[i];
            return result;
        }
    }
}
