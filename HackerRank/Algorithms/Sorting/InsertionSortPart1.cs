using System;

namespace HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/insertionsort1/problem
    /// </summary>
    public class InsertionSortPart1
    {
        public static void insertionSort1(int n, int[] arr)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] >= arr[j - 1]) continue;
                    var temp = arr[j];
                    arr[j] = arr[j - 1];
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    Console.WriteLine();
                    arr[j - 1] = temp;
                }

            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
