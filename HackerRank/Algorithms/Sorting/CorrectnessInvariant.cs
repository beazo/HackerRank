using System;

namespace HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/correctness-invariant/problem
    /// </summary>
    public class CorrectnessInvariant
    {
        public static void insertionSort(int[] A)
        {
            int j;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}
