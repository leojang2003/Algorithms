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
    }
}
