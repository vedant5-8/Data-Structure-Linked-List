using System;

namespace Data_Structure___Linked_List
{
    internal class LinkedList
    {
        Node head;

        public void Insert(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.Data);
            Console.WriteLine();
        }

        public void InsertFront(int data)
        {
            Node newNode = new Node(data);
            newNode.Data = data;
            newNode.Next = head;
            head = newNode;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty.");
            }
            else
            {
                Node temp = head;
                Console.WriteLine("Linked List contains");

                while (temp != null)
                {
                    Console.WriteLine("| " + temp.Data + " |");
                    temp = temp.Next;
                }
            }
        }
    }
}
