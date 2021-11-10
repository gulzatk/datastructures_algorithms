using System;

namespace bst_min_distance
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
            TreeNode n1 = new TreeNode(13);
            TreeNode n2 = new TreeNode(5);
            TreeNode n3 = new TreeNode(20);
            TreeNode n4 = new TreeNode(3);
            TreeNode n5 = new TreeNode(8);
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            int result = MinDiffInBST(n1);
            Console.WriteLine(result);
        }
        static int MinDiffInBST(TreeNode root) 
        {
            int minValue, maxValue;
            return MinDiff(root, out minValue, out maxValue);
        }

        static int MinDiff(TreeNode node, out int minValue, out int maxValue)
        {
            if (node == null)
            {
                minValue = 1000000;
                maxValue = -1000000;
                return int.MaxValue;
            }

            int leftMin, leftMax;
            int diff1 = MinDiff(node.left, out leftMin, out leftMax);
            int rightMin, rightMax;
            int diff2 = MinDiff(node.right, out rightMin, out rightMax);

            int diff3 = node.val - leftMax;
            int diff4 = rightMin - node.val;

            int bestMin = Math.Min(diff1, Math.Min(diff2, Math.Min(diff3, diff4)));
            minValue = Math.Min(node.val, leftMin);
            maxValue = Math.Max(node.val, rightMax);
            return bestMin; 
        }
    
    }
}
