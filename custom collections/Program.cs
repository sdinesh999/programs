using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class Program
    {
        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();
            list.add(1);
            list.add(2);
            list.add(3);
            list.printList();
            list.remove(1);
            list.printList();
            Console.Read();
        }
        
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }

    }
    public class LinkedList
    {
        Node head;
        public void add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node dummy = head;
                while (dummy.next != null)
                {
                    dummy = dummy.next;
                }
                dummy.next = newNode;
            }
        }

        public void printList()
        {
            Node dummy = head;
            while (dummy.next != null)
            {
                Console.WriteLine(dummy.data + " ");
                dummy = dummy.next;
            }
            Console.WriteLine(dummy.data);
        }


        public bool search(int data)
        {
            Node dummy = head;
            while (dummy != null)
            {
                if (dummy.data == data)
                    return true;

                dummy = dummy.next;
            }
            return false;

        }
        public void remove(int data)
        {

            if (head.data == data)
            {
                head = head.next;
            }
            else
            {
                if (search(data))
                {
                    Node dummy = head;
                    while (dummy.next.data != data)
                    {
                        dummy = dummy.next;
                    }

                    dummy.next = dummy.next.next;
                }

            }
        }
    }


}
