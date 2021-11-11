using System;
using System.Collections.Generic;

namespace cousins_binary_tree
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
    public class TreeNodeWithParent
    {
        public TreeNode node;
        public TreeNode parent;
        public TreeNodeWithParent(TreeNode node, TreeNode parent)
        {
            this.node = node;
            this.parent = parent;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            int x = 4;
            int y = 3;
            Console.WriteLine(IsCousins(n1, x, y));
        }

        static bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null)
        {
            return false;
        }
        Queue<TreeNodeWithParent> q = new Queue<TreeNodeWithParent>();
        q.Enqueue(new TreeNodeWithParent(root, null));
        
        while (q.Count != 0)
        {
            TreeNodeWithParent nodeX = null, nodeY = null;
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNodeWithParent curr = q.Dequeue();
                if (curr.node.val == x)
                {
                    nodeX = curr;
                }
                if (curr.node.val == y)
                {
                    nodeY = curr;
                }
                if (curr.node.left != null)
                {
                    q.Enqueue(new TreeNodeWithParent(curr.node.left, curr.node));
                }
                if (curr.node.right != null)
                {
                    q.Enqueue(new TreeNodeWithParent(curr.node.right, curr.node));
                }
            }
            
            if (nodeX != null || nodeY != null)
            {
                if (nodeX == null || nodeY == null)
                {
                    return false;
                }

                // here, both nodes are not null.
                // return true if parents are different
                // return false if parents are same
                return nodeX.parent != nodeY.parent;
            }
        }
        
        return false;
        }
    }
}
