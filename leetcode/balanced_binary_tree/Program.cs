using System;

namespace balanced_binary_tree
{
    class Program
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
        static void Main(string[] args)
        {
            TreeNode n1 = new TreeNode(3);
            TreeNode n2 = new TreeNode(9);
            TreeNode n3 = new TreeNode(20);
            TreeNode n4 = new TreeNode(15);
            TreeNode n5 = new TreeNode(7);
            Console.WriteLine(IsBalanced(n1));
        }

        static bool IsBalanced(TreeNode root)
        {
            int r = GetHeight(root);
            if (r == -1)
            {
                return false;
            }
            return true;
        }
        static int GetHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            
            }
            int left = GetHeight(root.left);
            int right = GetHeight(root.right);
            if (left == -1 || right == -1)
            {
                return -1;
            }
            if (Math.Abs(left - right) > 1)
            {
                 return -1;
            }
            return 1 + Math.Max(left, right);
        }
    }
}
