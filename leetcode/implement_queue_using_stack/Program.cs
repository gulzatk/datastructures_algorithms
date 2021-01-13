using System;
using System.Collections.Generic;

namespace implement_queue_using_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);            
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Empty());
        }

    }
    public class MyStack
    {
        Stack<int> myStack1 = new Stack<int>();
        Stack<int> myStack2 = new Stack<int>();

        static void MyQueue()
        {

        }
        // push element x to the back of queue
        public void Push(int x)
        {
            myStack1.Push(x);

        }
        // Remove the element in front of queue and return this element.
        public int Pop()
        {
            while (myStack1.Count != 0)
            {
                myStack2.Push(myStack1.Pop());
            }
            int x = myStack2.Pop();
            while (myStack2.Count != 0)
            {
                myStack1.Push(myStack2.Pop());
            }
            return x;
        }
        // Get the front element.
        public int Peek()
        {
            while (myStack1.Count != 0)
            {
                myStack2.Push(myStack1.Pop());
            }
            int peek = myStack2.Peek();
            while (myStack2.Count != 0)
            {
                myStack1.Push(myStack2.Pop());
            }
            return peek;
        }
        // return whether the queue is empty.
        public bool Empty()
        {
            return myStack1.Count == 0;
        }

    }
}
