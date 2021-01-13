using System;

namespace implement_queue_using_linkedList
{
    class ListNode
    {
        public int val;
        public ListNode next;
        // Constructor to create a new linked list
        public ListNode(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
    // A class represents queue
    class Queue
    {
        ListNode head;
        ListNode tail;
        public Queue()
        {
            this.head = this.tail = null;
        }
        // Add an element to the queue
        public void Enqueue(int data)
        {
            ListNode temp = new ListNode(data);
            if (this.head == null)
            {
                this.head = this.tail = temp;
            }
            else
            {
                // Add the input at the end of the queue and change tail
                this.tail.next = temp;
                this.tail = temp;
            }
        }
        public int Dequeue()
        {
            ListNode temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("The queue is empty");
                return -1;
            }
            // delete head data and move head head.next
            this.head = this.head.next;
            // if head becomes null change tail also as a null
            if (this.head == null)
            {
                this.tail = null;
            }
            return temp.val;
            Console.WriteLine("Item deleted is {0}", temp.val);
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
