using System;
using System.Collections.Generic;

namespace merge_2_sorted_linkedList
{
    // Definition for singly-linked list.
    class ListNode
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
            ListNode l13 = new ListNode(10, null);
            ListNode l12 = new ListNode(5, l13);
            ListNode l11 = new ListNode(1, l12);

            ListNode l22 = new ListNode(12, null);
            ListNode l21 = new ListNode(3, l22);
            ListNode merged = MergeTwoLists(l11, l21);

            while (merged != null){
                Console.Write(merged.val + ", ");
                merged = merged.next;
            }
        }
        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();            
            ListNode current = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }
            if (l1 == null)
            {
                current.next = l2;
            }
            else
            {
                current.next = l1;
            }
            return head.next;
        }
    }
}
