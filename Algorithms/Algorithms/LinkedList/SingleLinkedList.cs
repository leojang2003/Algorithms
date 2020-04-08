using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class SingleLinkedList
    {
        public Node head;

        public void Insert(int value)
        {
            var node = new Node(value);

            if (head == null)
                head = node;
            else
            {
                var current = head;
                while (current.next != null)
                    current = current.next;
                current.next = node;
            }
        }

        public void Print(Node node)
        {
            var current = node;

            if (current == null)
                Console.WriteLine("empty");

            while (current != null)
            {
                Console.Write(current.value);
                Console.Write(" ");
                current = current.next;
            }

            Console.Write(" EOS");
        }

        public Node Split()
        {
            Node current = head;
            Node slow = null;
            Node fast = null;
            Node previous_fast = head;

            if (current == null)
                return null;

            while (current.next != null)
            {
                slow = current.next;

                if (previous_fast.next != null)
                    fast = previous_fast.next.next;
                else
                    break;

                if (fast == null)
                    break;

                current = current.next;
                previous_fast = fast;
            }

            current.next = null;
            return slow;
        }

        public void RemoveDuplicateFromSorted()
        {
            var current = head;

            if (current == null)
                return;

            while (current.next != null)
            {
                if (current.value == current.next.value)
                {
                    current.next = current.next.next;
                }
                else
                    current = current.next;
            }
        }

        // Move front node of given linked list to the front of another list
        public Node MoveFrontToAnotherList(Node anotherHead)
        {
            if (head == null)
                return anotherHead;

            var temp = head.next;

            head.next = anotherHead;
            var head2 = head;

            head = temp;
            return head2;

        }

        // Move even nodes to the end of linked list in reverse order
        // Rearrange the give linked list such that every even node will be moved to end of the list
        // in reverse order
        // 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7
        // 1 -> 3 -> 5 -> 7 -> 6 -> 4 -> 2
        public void MoveEvenNodeToEndReverseOrder()
        {
            // Insert Dummy Node
            var dummy = new Node(0);
            dummy.next = head;

            var current = head;
            Node even = null;
            Node previous = dummy;

            while (current != null)
            {
                if (current.value % 2 == 0)
                {
                    var next = current.next;
                    previous.next = next;
                    if (even == null)
                    {
                        even = current;
                        even.next = null; // must terminate even list                     
                    }
                    else
                    {
                        current.next = even;
                        even = current;
                    }
                    current = next;
                }
                else
                {
                    previous = current;
                    current = current.next;
                }
            }
            previous.next = even;
            head = dummy.next;
        }

        // Construct a linked list by merging alternate nodes of two given lists
        // Given two linked lists, merge their nodes together to make one list, taking nodes alternately between the two lists. If either list runs out, all the nodes should be taken from the other list.
        // {1,2,3}, {7,13,1} -> {1,7,2,13,3,1}
        public void MergeAlternatingNodes(Node head2)
        {
            var current = head;

            var current2 = head2;

            // (debug found error) must check if list1 or list2 is empty 
            if (current == null)
            {
                head = current2;
                return;
            }

            if (current2 == null)
                return;

            while (current.next != null)
            {
                var next = current.next;
                var next2 = current2.next;

                if (current2 != null)
                {
                    current.next = current2;
                    current2.next = next;
                    current = current.next.next;
                    current2 = next2;
                }
                else
                    return;
            }

            if (current2 != null)
                current.next = current2;
        }

        // Merge two sorted linked lists into one
        // Write a function that takes two lists, each of which is sorted in increasing order, 
        // and merges the two together into one list which is in increasing order and return it.
        // {1,3,5} {2,4,6,7} -> {1,2,3,4,5,6,7}
        // The problem can be solved either iteratively or recursively.
        // There are many cases to deal with: either 'a' or 'b' may be empty, 
        // during processing either 'a' or 'b' may run out first, 
        // and finally there's the problem of starting the result list empty, 
        // and building it up while going through 'a' and 'b'
        public void MergeTwoSortedList(Node head2)
        {
            var list = new Node(0);
            Node current = head;
            Node current2 = head2;
            Node currentNext = null;
            Node current2Next = null;
            Node newCurrent = list; // Debug found error, need to add pointer to new list

            if (current == null)
                head = current2;

            if (current2 == null)
                return;

            while (current != null && current2 != null)
            {
                if (current.value < current2.value)
                {
                    currentNext = current.next;
                    newCurrent.next = current; // Debug found error, need to add pointer to new list
                    current.next = null;
                    current = currentNext;
                }
                else
                {
                    current2Next = current2.next;
                    newCurrent.next = current2; // Debug found error, need to add pointer to new list
                    current2.next = null;
                    current2 = current2Next;
                }
                newCurrent = newCurrent.next;
            }

            if (current == null)
                newCurrent.next = current2;
            if (current2 == null)
                newCurrent.next = current;

            head = list.next;
        }

        public void MergeSortGivenLinkedList(Node head2)
        {

        }

        // Intersection of two given sorted linked lists
        //Given two lists sorted in increasing order, create and return a new list representing the intersection of the two lists. 
        // The new list should be made with its own memory — the original lists should not be changed.
        // First List  : 1 -> 3 - > 4 -> 5 -> 6 -> 7 -> 10 -> null
        // Second List : 3 -> 4 -> 6 -> 8 -> 10 -> null
        // Output :  4 -> 10 -> null
        public Node IntersectionOfTwoGivenSortedLinkedLists(Node head2)
        {
            Node current = head;
            Node current2 = head2;

            var dummy = new Node(-1); // use dummy node;            
            var last = dummy; // Debug found error

            while (current != null && current2 != null)
            {
                if (current.value == current2.value)
                {
                    var node = new Node(current.value);
                    last.next = node;   // Debug found error
                    last = node;   // Debug found error

                    current = current.next;
                    current2 = current2.next;
                }
                else if (current.value < current2.value)
                {
                    current = current.next;
                }
                else
                {
                    current2 = current2.next;
                }
            }

            return dummy.next;
        }

        //   Input : 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null
        //   Output : 6 -> 5 -> 4 -> 3 -> 2 -> 1 -> null
        public Node ReverseLinkedList()
        {
            var dummy = new Node(-1);

            if (head == null)
                return head;

            var current = head;

            while (current != null)
            {
                var node = new Node(current.value);
                var temp = dummy.next;
                dummy.next = node;
                node.next = temp;
                current = current.next;
            }

            return dummy.next;
        }

        // Reverse every group of k nodes in given linked list
        // Given a linked list, reverse every adjacent group of k nodes in it where k is given positive integer.
        // Input List: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> null
        // For k = 3 Output: 3 -> 2 -> 1 -> 6 -> 5 -> 4 -> 8 -> 7 -> null
        // For k = 2 Output: 2 -> 1 -> 4 -> 3 -> 6 -> 5 -> 8 -> 7 -> null
        public Node ReverseEveryGroupOfKNodes(int k)
        {
            var dummy = new Node(-1);
            var groupHead = dummy; // save last node of each group
            var temp = dummy;
            var current = head;
            var count = 1;

            while (current != null && count <= k)
            {
                var node = new Node(current.value);
                var tmp = groupHead.next;
                groupHead.next = node;
                node.next = tmp;

                if (count == 1)
                    temp = node;

                count++;

                if (count > k)
                {
                    count = 1;
                    groupHead = temp;
                }

                current = current.next;
            }

            return dummy.next;
        }

        // Find K’th node from the end in a linked list
        // Given a linked list and a positive integer K, find K’th node from the end in a linked list.
        public int FindKthNodeFromTheEnd(int k)
        {
            var current = head;
            var count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            if (k > count)
                return -1;

            Node target = head;

            for (int i = 1; i <= count - k; i++)
            {
                target = target.next;
            }

            return target.value;
        }

        // Merge alternate nodes of two linked lists into the first list
        // Given two linked lists, merge their nodes together into first list by taking nodes alternately between the two lists. If first list runs out, remaining nodes of second list should not be moved.
        // {1, 2, 3}, {4, 5, 6, 7, 8} -> {1, 4, 2, 5, 3, 6} and {7, 8}
        public Node MergeAlternateNodes(Node head2)
        {
            var dummy = new Node(-1);
            var tail = dummy;
            var current = head;
            var current2 = head2;

            while (current != null && current2 != null)
            {
                var currentNext = current.next;
                var current2Next = current2.next;

                tail.next = current;
                current.next = current2;
                current2.next = null;
                tail = current2;

                current = currentNext;
                current2 = current2Next;
            }

            if (current == null && current2 != null)
                head2 = current2;
            else if (current != null && current2 == null)
                head2 = current;
            else
                head2 = null;

            head = dummy.next;
            return head2;
        }

        // Delete every N nodes in a linked list after skipping M nodes
        // Given a linked list and two positive integers M and N, delete every N nodes in it after skipping M nodes.
        // 1 -> 2 -> 3 ->  4 -> 5 -> 6 -> 7 -> 8 -> 9 -> 10 -> null
        // If M = 1, N =3
        // 1 -> 5 -> 9 -> null
        public void DeleteEveryNNodesAfterSkippingMNodes(int m, int n)
        {
            var dummy = new Node(-1);
            dummy.next = head;
            var current = dummy;
            int skipCount = 0; // the nodes skipped

            while (current != null)
            {
                if(skipCount == m)
                {
                    var temp = current;

                    skipCount = 0; // reset skip count
                    var deleteCount = 0; // start delete count
                    while(current.next != null && deleteCount <= n)
                    {
                        if(deleteCount == n)
                        {
                            temp.next = current.next; // debug found error
                            //current = current.next.next;
                            break;                           
                        }
                        else
                        {                           
                            current = current.next;
                            temp.next = null; // debug found error
                            deleteCount++;
                        }                        
                    }

                    // debug found error, handle node less than n
                    if(current.next == null)
                        return;
                }
                else
                {
                    current = current.next;
                    skipCount++;
                }
            }             
        }

        // Merge two sorted linked lists from their end
        // Write a function that takes two lists, each of which is sorted in increasing order, and merges the two together into one list which is in decreasing order and return it. In other words, merge two sorted linked lists from their end.
        // {1, 3, 5}, {2, 6, 7, 10} -> {10, 7, 6, 5, 3, 2, 1}
        public Node MergeTwoSortedLinkedListsFromEnd(Node head2)
        {
            var current = head;
            var current2 = head2;
            var dummy = new Node(-1);

            while (current != null && current2 != null)
            {
                if (current.value < current2.value)
                {
                    var currentNext = current.next;

                    var next = dummy.next;
                    dummy.next = current;
                    current.next = next;

                    current = currentNext;
                }
                else
                {
                    var current2Next = current2.next;

                    var next = dummy.next;
                    dummy.next = current2;
                    current2.next = next;

                    current2 = current2Next;
                }
            }

            if (current == null)
            {
                while (current2 != null)
                {
                    var current2Next = current2.next;

                    var next = dummy.next;
                    dummy.next = current2;
                    current2.next = next;

                    current2 = current2Next;
                }
            }
            else
            {
                while (current != null)
                {
                    var currentNext = current.next;

                    var next = dummy.next;
                    dummy.next = current;
                    current.next = next;

                    current = currentNext;
                }
            }

            return dummy.next;
        }
    }
}
