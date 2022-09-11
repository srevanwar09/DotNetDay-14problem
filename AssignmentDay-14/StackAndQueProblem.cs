using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblem
{
    internal class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data) // this method is used to add elements in queue
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue ", node.data);
        }
        internal void Display()// this method is used to display the elements in queue
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;

            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Dequeue()// this method is used to remove the elements from beginning
        {
            if (head == null)
            {
                Console.WriteLine("\nQueue is empty");
            }
            else
            {
                Console.WriteLine("\nThe Dequeue element is : " + head.data);
                head = head.next;
            }
        }
    }
}
