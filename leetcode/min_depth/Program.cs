using System;

namespace min_depth
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
            n3.left = n4;
            n3.right = n5;
            Console.WriteLine(MinDepth(n1));
        }

        static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = MinDepth(root.left);
            int right = MinDepth(root.right);
            if(left == 0)
            {
                return 1 + right;
            }
            else if (right == 0)
            {
                return 1 + left;
            }
            else
            {
                return 1 + Math.Min(left, right);
            }    
        }
        
    }
}
