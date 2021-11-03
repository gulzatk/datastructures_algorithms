using System;

namespace max_depth_binary_tree
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
            Console.WriteLine(MaxDepth(n1));
        }

        static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return 1 + Math.Max(left, right);
        }
        
    }
}
