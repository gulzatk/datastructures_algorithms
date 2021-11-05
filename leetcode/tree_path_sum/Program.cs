using System;

namespace tree_path_sum
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
            TreeNode n1 = new TreeNode(5);
            TreeNode n2 = new TreeNode(4);
            TreeNode n3 = new TreeNode(8);
            TreeNode n4 = new TreeNode(11);
            TreeNode n5 = new TreeNode(13);
            TreeNode n6 = new TreeNode(4);
            TreeNode n7 = new TreeNode(7);
            TreeNode n8 = new TreeNode(2);
            TreeNode n9 = new TreeNode(1);
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n3.left = n5;
            n3.right = n6;
            n4.left = n7;
            n4.right = n8;
            n6.right = n9;
            Console.WriteLine(HasPathSum(n1, 22));
        }

        static bool HasPathSum(TreeNode root, int target)
        {
            if (root == null)
            {
                return false;
            }

            target = target - root.val;
            if (root.left == null && root.right == null && target == 0)
            {
                return true;
            }
            return HasPathSum(root.left, target) || HasPathSum(root.right, target);

        }
    }
}
