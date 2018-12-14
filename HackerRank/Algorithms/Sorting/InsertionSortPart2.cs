using System;

namespace HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/insertionsort2/problem
    /// </summary>
    public class InsertionSortPart2
    {
        public static void insertionSort2(int n, int[] arr)
        {
            for (int i = 0; i < n - 1; i++)
            {
                var start = i;
                for (int j = 0; j < start + 1; j++)
                {
                    if (arr[i] <= arr[i + 1]) continue;
                    Swap(arr, i, i + 1);
                    i--;
                }
                i = start;
                Console.WriteLine(string.Join(" ", arr));
            }
        }
        private static void Swap(int[] ar, int x, int y)
        {
            var tmp = ar[x];
            ar[x] = ar[y];
            ar[y] = tmp;
        }
    }
}
