using System;
using System.Collections.Generic;

namespace leaf_similar
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
            TreeNode n2 = new TreeNode(5);
            TreeNode n3 = new TreeNode(1);
            TreeNode n4 = new TreeNode(6);
            TreeNode n5 = new TreeNode(2);
            TreeNode n6 = new TreeNode(9);
            TreeNode n7 = new TreeNode(8);
            TreeNode n8 = new TreeNode(7);
            TreeNode n9 = new TreeNode(4);
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n3.left = n6;
            n3.right = n7;
            n5.left = n8;
            n5.right = n9;

            TreeNode r1 = new TreeNode(3);
            TreeNode r2 = new TreeNode(5);
            TreeNode r3 = new TreeNode(1);
            TreeNode r4 = new TreeNode(6);
            TreeNode r5 = new TreeNode(7);
            TreeNode r6 = new TreeNode(4);
            TreeNode r7 = new TreeNode(2);
            TreeNode r8 = new TreeNode(9);
            TreeNode r9 = new TreeNode(8);
            r1.left = r2;
            r1.right = r3;
            r2.left = r4;
            r2.right = r5;
            r3.left = r6;
            r3.right = r7;
            r7.left = r8;
            r7.right = r9;
            Console.WriteLine(LeafSimilar(n1, r1));
        }

        static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> t1 = new List<int>();
            List<int> t2 = new List<int>();
            GetLeaves(root1, t1);
            GetLeaves(root2, t2);
            if (t1.Count != t2.Count)
            {
                return false;
            }
            for (int i = 0; i < t1.Count; i++)
            {
                if (t1[i] != t2[i])
                {
                    return false;
                }
            }
            return true;
        }

        static void GetLeaves(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            if (root.left == null && root.right == null)
            {
                list.Add(root.val);
            }
            GetLeaves(root.left, list);
            GetLeaves(root.right, list);
        }
    }
}
