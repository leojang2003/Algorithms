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
        public Node MergeAlternatingNodes(Node head2)
        {            
            
        }
    }
}
