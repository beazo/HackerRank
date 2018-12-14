namespace HackerRank.CrackingTheCodingInterview
{
    /// <summary>
    /// This is the solution only, for implementation and test cases view the below URL
    /// https://www.hackerrank.com/challenges/ctci-is-binary-search-tree/problem
    /// </summary>
    public class TreesBinarySearch
    {
        public class Node
        {
            public int data { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }
        }

        public bool checkBST(Node root, int min = -1, int max = 10001)
        {
            if (root == null)
                return true;
            if (root.data <= min || root.data >= max)
                return false;
            return checkBST(root.left, min, root.data) && checkBST(root.right, root.data, max);
        }
    }
}
