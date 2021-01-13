using System;

namespace implement_stck_using_linkedlist
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
    class Stack
    {
        ListNode head;

        public Stack()
        {
            head = null;
        }

        // Add data in to the stack
        public void Push(int data)
        {
            ListNode temp = new ListNode(data);
            if (head == null)
            {
                head = temp;
            }
            temp.next = head;
            head = temp;
        }
        // Delete an element from stack
        public int Pop()
        {
            ListNode temp = head;
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            head = head.next;
            Console.WriteLine("Item popped is {0}", temp.val);
            return temp.val;
        }
        
        public int Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            Console.WriteLine("{0} is on the top of the stack", head.val);
            return head.val;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Pop();
            myStack.Pop();
            myStack.Peek();
        }
    }
}
