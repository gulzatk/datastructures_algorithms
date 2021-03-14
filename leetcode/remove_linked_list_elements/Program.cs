using System;

namespace remove_linked_list_elements
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
            ListNode head3 = new ListNode(6, null);
            ListNode head2 = new ListNode(5, head3);
            ListNode head1 = new ListNode(1, head2);
            ListNode result = RemoveElements(head1, 5);
            while(result != null){
            Console.Write(result.val);
            result = result.next;

            }
    }
        static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummyHead = new ListNode(val - 1, head);
            ListNode current = dummyHead;
            while (current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return dummyHead;
        }


    }
}
