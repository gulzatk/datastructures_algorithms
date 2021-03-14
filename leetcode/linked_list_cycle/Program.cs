using System;
using System.Collections.Generic;

namespace linked_list_cycle
{

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x, ListNode nextNode = null)
        {
            val = x;
            next = nextNode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head3 = new ListNode(6, null);
            ListNode head2 = new ListNode(5, head3);
            ListNode head1 = new ListNode(1, head2);
            head3.next = head1;
            bool result = HasCycle1(head1);
            bool secondMethod = HasCycle2(head1);
            Console.WriteLine(result);
            Console.WriteLine(secondMethod);
    
        }
// In this solution we use set to check a node if its already visited or not.
//Time Complexity: O(N);
//Space Conplexity: O(N);
        static  bool HasCycle1(ListNode head)
        {
            HashSet<ListNode> checkList = new HashSet<ListNode>();

            while(head != null)
            {
                if (!checkList.Contains(head))
                {
                    checkList.Add(head);
                    head = head.next;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

// in this colution we have 2 pointers. 
// Time Complexity: O(N);
// SpaceComplexity: O(1);
        static bool HasCycle2(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
        // this loop runs untill fast reaches the end/tail
        // we don't need to check slow, because fast reaches ens earlier.
        // this check handles the case where linked list is empty.
            while (fast != null)
            {
                // to make sure fast.next.next doesn't throw exception.
                if (fast.next == null)
                {
                    return false;
                }
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }
    }
    

    
}
