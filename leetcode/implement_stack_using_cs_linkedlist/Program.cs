using System;
using System.Collections.Generic;

namespace implement_stack_using_cs_linkedList
{

    // A class represents a stack
    class Stack
    {
        LinkedList<int> list;
        public Stack()
        {
            list = new LinkedList<int>();
        }

        // Add an element to the stack
        public void Push(int data)
        {
            list.AddLast(data);
        }

        // Returns latest pushed element by removing it from the stack
        public int Pop()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }

            int val = list.Last.Value;
            list.RemoveLast();
            return val;
        }

        // Returns latest pushed element without removing it from the stack
        public int Peek()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }

            return list.Last.Value;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
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
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
        }
    }
}
