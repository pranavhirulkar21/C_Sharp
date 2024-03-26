using System;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    class Program
    {
        class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        class LinkedList
        {
            
            Node head;

            public LinkedList()
            {
                head = null;
            }
            public void InsertAtStart(int data)
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }

            public void InsertAtEnd(int data)
            {
                Node newNode = new Node(data);

                if(head == null) 
                {
                    head = new Node(data);
                    return;
                }

                newNode.next = null;
                Node last = head;
                while(last.next != null)
                    last = last.next;

                last.next = newNode;
            }

            public void InsertAtPosition(int position, int newData)
            {
                Node newNode = new Node(newData);

                if(position == 0)
                {
                    newNode.next = head;
                    head = newNode;
                    return;
                }

                Node current = head;
                for(int i = 0; i < position-1 && current != null; i++)
                {
                    current = current.next;
                }

                if(current == null)
                {
                    Console.WriteLine("Position is out of bounds");
                    return;
                }
                newNode.next = current.next;
                current.next = newNode;
            }

            public void RemoveAtStart()
            {
                if(head != null)
                {
                    head = head.next;
                }
            }

            public void RemoveAtEnd()
            {
                if (head == null || head.next == null)
                    head = null;

                Node current = head;
                while(current.next != null && current.next.next != null)
                    current = current.next;
                current.next = null;
            }

            public void RemoveAtPosition(int position)
            {
                if (head == null)
                    return;

                if (position == 0)
                    head = head.next;

                Node temp = head;

                for(int i = 0; temp != null && i < position-1; i++)
                    temp = temp.next;

                if (temp == null || temp.next == null)
                    return;

                temp.next = temp.next.next;
            }


            public void PrintList() 
            {
                Node trav = head;
                while(trav != null)
                {
                    Console.WriteLine(trav.data);
                    trav = trav.next; 
                }

            
            }
        }
        static void Main(string[] args)
        {
            LinkedList mylist = new LinkedList();
            mylist.InsertAtStart(10);
            mylist.InsertAtStart(20);
            mylist.InsertAtStart(30);
            mylist.InsertAtEnd(100);
            mylist.InsertAtEnd(90);
            mylist.InsertAtEnd(70);

            mylist.InsertAtPosition(3, 50);

            mylist.PrintList();
            Console.WriteLine();

            //mylist.RemoveAtStart();
            //mylist.RemoveAtEnd();
            //mylist.RemoveAtPosition(3);

            mylist.PrintList();
            Console.WriteLine();

        }
    }
}
