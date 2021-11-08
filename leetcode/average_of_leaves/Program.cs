using System;
using System.Collections.Generic;

namespace average_of_leaves
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
            IList<double> r = AverageOfLeaves(n1);
            foreach (double n in r)
            {
                Console.WriteLine(n);
            }
        }

        static IList<double> AverageOfLeaves(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            List<double> result = new List<double>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                double sum = 0;
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode curr = q.Dequeue();
                    sum = sum + curr.val;
                    if (curr.left != null)
                    {
                        q.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        q.Enqueue(curr.right);
                    }

                }
                result.Add(sum / size);
            }
            return result;
        }
    }
}
