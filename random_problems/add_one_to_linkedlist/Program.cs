using System;

namespace add_one_to_linkedlist
{
    class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
    class Program
    {
        static ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode nextValue = head.next;
                head.next = prev;
                prev = head;
                head = nextValue;
            }
            return prev;
        }
        static ListNode AddOne(ListNode head)
        {
            head = Reverse(head);
            ListNode current = new ListNode(head.value);
            current.value++;
            ListNode newHead = current;
            int carryOver = current.value / 10;
            current.value %= 10;
            while (head.next != null)
            {
                current.next = new ListNode(head.next.value + carryOver);
                carryOver = current.next.value / 10;
                current.next.value %= 10;
                head = head.next;
                current = current.next;
            }
            if (carryOver == 1)
            {
                current.next = new ListNode(1);
            }
            return Reverse(newHead);
        }
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(9);
            ListNode l2 = new ListNode(9);
            ListNode l3 = new ListNode(9);
            l1.next = l2;
            l2.next = l3;

            ListNode addedList = AddOne(l1);
            while (addedList != null)
            {
                Console.WriteLine(addedList.value);
                addedList = addedList.next;
            }
        }
    }
}
