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
                if(current.value == current.next.value)
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

            while(current != null)
            {
                if(current.value % 2 == 0)
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

            while(current.next != null)
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
        // There are many cases to deal with: either ?˜a??or ?˜b??may be empty, 
        // during processing either ?˜a??or ?˜b??may run out first, 
        // and finally there?™s the problem of starting the result list empty, 
        // and building it up while going through ?˜a??and ?˜b??
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

            while(current != null && current2 != null)
            {
                if(current.value < current2.value)
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

        public void MergeSortGivenLinkedList()
        {

        }

        // Intersection of two given sorted linked lists
        //Given two lists sorted in increasing order, create and return a new list representing the intersection of the two lists. 
        // The new list should be made with its own memory ¡X the original lists should not be changed.
        // First List  : 1 -> 4 -> 7 -> 10 -> null
        // Second List : 2 -> 4 -> 6 -> 8 -> 10 -> null
        // Output :  4 -> 10 -> null
        public void IntersectionOfTwoGivenSortedLinkedLists(Node head2)
        {

        }
    }
}
