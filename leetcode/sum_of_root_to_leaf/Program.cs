using System;

namespace sum_of_root_to_leaf
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
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(0);
            TreeNode n3 = new TreeNode(1);
            TreeNode n4 = new TreeNode(0);
            TreeNode n5 = new TreeNode(1);
            TreeNode n6 = new TreeNode(0);
            TreeNode n7 = new TreeNode(1);
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n3.left = n6;
            n3.right = n7;
            Console.WriteLine(SumRootToLeaf(n1));
        }
        static int SumRootToLeaf(TreeNode root)
        {
            int sum = 0;
            GetSum(root, ref sum, 0);
            return sum;
        }
        static void GetSum(TreeNode node, ref int sum, int curr)
        {
            if (node == null)
            {
                return;
            }
            curr = curr * 2;
            curr = curr + node.val;
            if (node.left == null && node.right == null)
            {
                sum = sum + curr;
                return;
            }
            GetSum(node.left, ref sum, curr);
            GetSum(node.right, ref sum, curr);
        }
    }
}
