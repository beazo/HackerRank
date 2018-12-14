namespace HackerRank.Algorithms.Sorting
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/runningtime/problem
    /// </summary>
    public class RunningTimeAlgorithms
    {
        public static int runningTime(int[] arr)
        {
            var num = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                        num++;
            }
            return num;
        }
    }
}
