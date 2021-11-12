using System;

namespace second_minimum_in_bt
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
            TreeNode n1 = new TreeNode(2);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(5);
            TreeNode n4 = new TreeNode(5);
            TreeNode n5 = new TreeNode(7);
            n1.left = n2;
            n1.right = n3;
            n3.left = n4;
            n3.right = n5;
            Console.WriteLine(FindSecondMinimumValue(n1));
        }

        static int FindSecondMinimumValue(TreeNode root)
        {
            long minValue = long.MaxValue;
            long minValue2 = long.MaxValue;
            Dfs(root, ref minValue, ref minValue2);
            if (minValue2 == long.MaxValue)
            {
                return -1;
            }
            return (int)minValue2;
        }
        static void Dfs(TreeNode node, ref long minValue, ref long minValue2)
        {
            if (node == null)
            {
                return;
            }
            Dfs(node.left, ref minValue, ref minValue2);
            Dfs(node.right, ref minValue, ref minValue2);
            if (node.val < minValue)
            {
                minValue2 = minValue;
                minValue = node.val;                 
            }
            if (node.val > minValue && node.val < minValue2)
            {
                minValue2 = node.val;
            }
        }
    }
}
