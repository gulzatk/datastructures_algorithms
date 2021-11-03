using System;
using System.Collections.Generic;

namespace binary_tree_paths
{
    // Definition for a binary tree node.
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
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(5);
            n1.left = n2;
            n1.right = n3;
            n2.left = null;
            n2.right = n4;
            IList<string> result = TreeNodePaths(n1);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static IList<string> TreeNodePaths(TreeNode root)
        {
            List<string> result = new List<string>();
            Paths(root, "", result);
            return result;
        }

        static void Paths(TreeNode node, string path, IList<string> list)
        {
            if (node == null)
            {
                return;
            }

            path = path + node.val + "->";
            if (node.left == null && node.right == null)
            {
                list.Add(path.Remove(path.Length-2));
                return;
            }
            Paths(node.left, path, list);
            Paths(node.right, path, list);
        } 
    }
}
