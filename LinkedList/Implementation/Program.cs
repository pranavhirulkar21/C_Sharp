using System;
using System.Collections.Generic;
    
    internal class LinkedList
    {
        Node head;

        public class Node 
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                data = data;
                next = null;
            }
        }

        public void InsertAtStart(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = head;
            head = newNode;
        }

        public void InsertAtEnd(int newData)
        {
            Node newNode = new Node(newData);
            if(head == null)
            {
                head = new Node(newData);
                return;
            }

            newNode.next = null;
            Node last = head;

            while (last.next != null)
                last.next = last;

            last.next = newNode;
        }

        public void PrintList()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data+" ");
                node = node.next;
            }
        }
        public static void Main(string[] args)
        {
        LinkedList list = new LinkedList();

        list.InsertAtStart(20);
        list.InsertAtStart(30);
   
        list.PrintList();

        }
    }

