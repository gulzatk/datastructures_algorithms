using System;

namespace reverse_linked_list
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(5);
            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            ListNode reversed = ReverseList(l1);
            while (reversed != null)
            {
                Console.WriteLine(reversed.val);
                reversed = reversed.next;
            }
        }
        static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
    }
}
