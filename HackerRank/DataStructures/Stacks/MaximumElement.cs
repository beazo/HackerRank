using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.DataStructures.Stacks
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/maximum-element/problem
    /// </summary>
    public class MaximumElement
    {
        private class StackNode
        {
            public int val;
            public int curMax;
            public StackNode(int val, int curMax)
            {
                this.val = val;
                this.curMax = curMax;
            }

            public new string ToString()
            {
                return val + " [" + curMax + "]";
            }
        }

        public static void Solution()
        {
            int n = Console.Read();
            int max = int.MaxValue;
            Stack<StackNode> stack = new Stack<StackNode>();
            while (n > 0)
            {
                int choice = Console.Read();
                if (choice == 1)
                {
                    int val = Console.Read();
                    max = Math.Max(val, max);
                    stack.Push(new StackNode(val, max));
                }
                else if (choice == 2)
                {
                    if (stack.Any())
                        stack.Pop();
                    // reset max
                    max = !stack.Any() ? int.MaxValue : stack.Peek().curMax;
                }
                else if (choice == 3 && stack.Any())
                    Console.WriteLine(stack.Peek().curMax);

                n--;
            }
        }
    }
}


