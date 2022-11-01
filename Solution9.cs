using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogrithmPractice
{
    internal class Solution9
    {

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

        public class Solution
        {
            public ListNode DeleteDuplicates(ListNode l)
            {
                ListNode head = l;
                if (head.next == null)
                {
                    return head;
                }
                while (head.next != null)
                {
                    if (head.next.val == head.val)
                    {
                        head.next = head.next.next;
                    }
                    else
                    {
                        head = head.next;
                    }
                }
                return l;
            }
        }
    }
}
