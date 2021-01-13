using System;
using System.Collections.Generic;

namespace implement_queue_using_linkedList
{

    // A class represents queue
    class Queue
    {
        LinkedList<int> list;
        public Queue()
        {
            list = new LinkedList<int>();
        }
        // Add an element to the queue
        public void Enqueue(int data)
        {
            list.AddLast(data);
        }
        
        public int Dequeue()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The queue is empty");
                return -1;
            }

            int val = list.First.Value;
            list.RemoveFirst();
            return val;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
