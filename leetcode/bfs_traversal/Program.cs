using System;
using System.Collections.Generic;

namespace bfs_traversal
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
            BfsTraversal(n1);
        }

        static void BfsTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 1;
            while (queue.Count != 0)
            {
                Console.Write("level " + (level++) + ": ");
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode curr = queue.Dequeue();
                    Console.Write(curr.val + " ");
                    if (curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
