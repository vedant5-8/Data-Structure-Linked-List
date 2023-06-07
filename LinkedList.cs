using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Linked_List
{
    internal class LinkedList
    {
        Node head;

        // UC2 - Insert node from front of linked list

        public void InsertFront(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Data = data;
                newNode.Next = head;
                head = newNode;
            }
            Console.WriteLine("{0} inserted into linked list", newNode.Data);
            Console.WriteLine();
        }

        // UC3 - Insert node to end of linked list

        public void InsertEnd(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            Console.WriteLine("{0} inserted into linked list", newNode.Data);
            Console.WriteLine();
        }

        // UC4 - insert data into specific position

        public void InsertBetween(int data, int position)
        {
            Node newNode = new Node(data);
            newNode.Data = data;
            newNode.Next = null;

            if (position < 1)
            {
                Console.WriteLine("\nPosition should be greater than 1");
            }
            else if (position == 1) 
            {
                newNode.Next = head;
                head = newNode;
            } 
            else
            {
                Node temp = head;
                for(int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                    }
                }

                if (temp != null)
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                }
                else
                {
                    Console.WriteLine("\nThe previous node is null.");
                }
            }

        }

        // UC5 - Delete first node in linked list

        public void RemoveFirst()
        {
            if (head != null)
            {
                Node temp = head;
                head = head.Next;
                temp = null;
            }
        }

        // UC6 - Delete last node in linked list

        public void RemoveLast()
        {
            if (head != null)
            {
                if (head.Next == null)
                {
                    head = null;
                }
                else
                {
                    Node temp = head;
                    while(temp.Next != null)
                    {
                        temp = temp.Next;
                        Node lastNode = temp.Next;
                        temp.Next = null;
                        lastNode = null;
                    }
                }
            }
        }

        // UC7 - search the value og node in linked list

        public void searchNode(int data)
        {
            Node temp = head;
            int found = 0;
            int i = 0;

            if(temp != null)
            {
                while (temp != null)
                {
                    i++;

                    if(temp.Data == data)
                    {
                        found++;
                        break;
                    }
                    temp = temp.Next;
                }
                if (found == 1)
                {
                    Console.WriteLine("\n{0} is found at index = {1}.", data, i);
                } 
                else
                {
                    Console.WriteLine("\n{0} is not found in the list.", data);
                }
            } 
            else
            {
                Console.WriteLine("List is Empty");
            }
        }

        // UC8 - insert an given element after a specific element

        public void InsertAfter(int prev_data, int data)
        {
            Node temp = head;

            while (temp != null && temp.Data != prev_data)
            {
                temp = temp.Next;
            }

            if (temp != null)
            {
                Node newNode = new Node(data);
                newNode.Data = data;
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
        }

        // UC9 - delete specific data from the Linked List
        // and show the size of LinkedList
        public void Remove(int data)
        {
            Node temp = head;
            Node previous = null;

            while (temp != null && temp.Data != data)
            {
                previous = temp;
                temp = temp.Next;
            }

            if (temp != null)
            {
                if (previous == null)
                {
                    head = temp.Next;
                }
                else
                {
                    previous.Next = temp.Next;
                }
            }
        }

        public void countNodes()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine("Size of the list is " + count);
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
