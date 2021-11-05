using System;

namespace sum_of_left_leaves
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode n1 = new TreeNode(3);
            TreeNode n2 = new TreeNode(9);
            TreeNode n3 = new TreeNode(20);
            TreeNode n4 = new TreeNode(15);
            TreeNode n5 = new TreeNode(7);
            n1.left = n2;
            n1.right = n3;
            n2.left = null;
            n2.right = null;
            n3.left = n4;
            n3.right = n5;
            int result = SumOfLeftLeaves(n1);
            Console.WriteLine(result);
        }

        static int SumOfLeftLeaves(TreeNode root)
        {
            int sum = Sum(root, false);
            return sum;
        }

        static int Sum(TreeNode node, bool isLeft)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.left == null && node.right == null)
            {
                return isLeft ? node.val : 0;
            }
            int left = Sum(node.left, true);
            int right = Sum(node.right, false);
            return left + right;
        }
    }
}
