using System;

namespace tree_implementation
{
    public class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(3);
            root.left = new Node(2);
            root.right = new Node(5);
            Insert(root, 6);
            InOrderPrint(root);
        }

        public static void Insert(Node node, int value)
        {
            if (value <= node.data)
            {
                if (node.left == null)
                {
                    node.left = new Node(value);
                }
                else
                {
                    Insert(node.left, value);
                }
            }
            else
            {
                if (node.right == null)
                {
                    node.right = new Node(value);
                }
                else
                {
                    Insert(node.right, value);
                }
            }
        }

        public static void InOrderPrint(Node node)
        {
            if (node == null){
                return;
            }

            InOrderPrint(node.left);
            Console.WriteLine(node.data);
            InOrderPrint(node.right);
        }

        public static bool Contains(Node node, int target)
        {
            if (node == null){
                return false;
            }

            if (node.data == target)
            {
                return true;
            }

            if (node.data >= target)
            {
                return Contains(node.left, target);
            }

            return Contains(node.right, target);
        }
    }
}
