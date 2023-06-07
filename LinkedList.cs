using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Linked_List
{
    internal class LinkedList<T> where T : IComparable<T>
    {
        Node<T> head;

        // UC2 - Insert node from front of linked list

        public void InsertFront(T data)
        {
            Node<T> newNode = new Node<T>(data);

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

        public void InsertEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;

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

        public void InsertBetween(T data, int position)
        {
            Node<T> newNode = new Node<T>(data);
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
                Node<T> temp = head;
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
                Node<T> temp = head;
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
                    Node<T> temp = head;
                    while(temp.Next != null)
                    {
                        temp = temp.Next;
                        Node<T> lastNode = temp.Next;
                        temp.Next = null;
                        lastNode = null;
                    }
                }
            }
        }

        // UC7 - search the value of node in linked list

        public bool Search(T data)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.Data.Equals(data))
                {
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        // UC8 - insert an given element after a specific element

        public void InsertAfter(T prev_data, T data)
        {
            Node<T> temp = head;

            while (temp != null && !temp.Data.Equals(prev_data))
            {
                temp = temp.Next;
            }

            if (temp != null)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Data = data;
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
        }

        // UC9 - delete specific data from the Linked List
        // and show the size of LinkedList
        public void Remove(T data)
        {
            Node<T> temp = head;
            Node<T> previous = null;

            while (temp != null && !temp.Data.Equals(data))
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
            Node<T> temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine("Size of the list is " + count);
        }

        // UC10 - create Ordered Linked List in ascending order

        public void sort()
        {
            Console.Write("Sorted ");
            Node<T> current = head;

            while (current != null && current.Next != null)
            {
                Node<T> nextNode = current.Next;

                if (current.Data.CompareTo(nextNode.Data) > 0)
                {
                    T temp = current.Data;
                    current.Data = nextNode.Data;
                    nextNode.Data = temp;

                    current = nextNode;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty.");
            }
            else
            {
                Node<T> temp = head;
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
