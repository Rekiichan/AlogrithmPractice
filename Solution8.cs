using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AlogrithmPractice
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
    public class LinkedList
    {
        ListNode head;
        public LinkedList()
        {
            head = null;
        }
        public void addTail(int data)
        {
            if (data == null)
            {
                head = new ListNode(data);
            }
            else
            {
                while (head.next != null)
                {

                }
                ListNode newNode = new ListNode(data);
                head.next = newNode;
            }
        }
        public void nhapdanhsach(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                addTail(arr[i]);
            }
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;


            if (l2.val > l1.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);

                return l1;
            }

            l2.next = MergeTwoLists(l1, l2.next);
            return l2;

        }
    }
    public class Solution8
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }

            if (list1.val > list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            list2.next = MergeTwoLists(list1.next, list2);
            return list2;
        }
    }
}
