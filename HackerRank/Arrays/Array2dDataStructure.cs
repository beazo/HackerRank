namespace HackerRank.Arrays
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/2d-array/problem
    /// </summary>
    public class Array2dDataStructure
    {
        public static int hourglassSum(int[][] arr)
        {
            int max = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int i = 0; i <= arr[row].Length - 3; i++)
                {
                    //each calculation is it's own object to easily identify what is occuring
                    var top1 = arr[row][i];
                    var top2 = arr[row][i + 1];
                    var top3 = arr[row][i + 2];

                    var mid = arr[row + 1][i + 1];

                    var bot1 = arr[row + 2][i];
                    var bot2 = arr[row + 2][i + 1];
                    var bot3 = arr[row + 2][i + 2];

                    var num = top1 + top2 + top3 + mid + bot1 + bot2 + bot3;

                    if (num > max)
                        max = num;
                }
            }
            return max;
        }
    }
}
