using System;
using System.Collections.Generic;

namespace implement_queue_using_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a queue of capacity 4
            Queue myQueue = new Queue(4);

            

            //Insert Elements to the queue
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);

            // Print queue elements
            myQueue.DisplayQueue();

            //Delete an element from queue
            int first = myQueue.Dequeue();
            int second = myQueue.Dequeue();
            Console.WriteLine(first);
            Console.WriteLine(second);

            // Print elements of queue
            myQueue.DisplayQueue();
        }
    }
    public class Queue 
    {
        private static int front, rear, capacity;
        private static int []queue;

        public Queue(int x)
        {
            front = -1;
            rear = -1;
            capacity = x;
            queue = new int[capacity];
        }
        // Check if queue is empty
        public bool IsEmpty()
        {
            if (front == -1 && rear == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Insert an element at the end of the queue
        public void Enqueue(int data)
        {
            if (rear == capacity)
            {
                Console.WriteLine("Queue is full");
            }
            else if (IsEmpty())
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear++;               
            }
            queue[rear] = data; 
        }
        //Delete an element from the front of the queue
        public int Dequeue()
        {
            int returnValue = queue[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            } else {
                front = front + 1;
                
            }
            return returnValue;
        }
        //Display all elements of the queue

        public void DisplayQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            for (int i = front; i <= rear; i++)
            {
                Console.Write(" {0} <--", queue[i]);
            }
        }
    }
}
