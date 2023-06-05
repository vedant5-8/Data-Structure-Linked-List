﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Linked_List
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // UC2 - Insert node from front

            /*
            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(56);

            list.Display();
            */

            // UC3 - Insert node to end

            /*
            list.InsertEnd(56);
            list.InsertEnd(30);
            list.InsertEnd(70);

            list.Display();
            */

            // UC4 - insert data into specific position

            /*
            list.InsertEnd(56);
            list.InsertEnd(70);

            list.Display();

            list.InsertBetween(30, 2);

            list.Display();
            */

            // UC5 - delete first node in linked list

            /*
            list.InsertEnd(56);
            list.InsertEnd(30);
            list.InsertEnd(70);

            list.Display();

            list.RemoveFirst();
            list.Display();
            */

            // UC6 - Delete last node in linked list

            /*
            list.InsertEnd(56);
            list.InsertEnd(30);
            list.InsertEnd(70);

            list.Display();

            list.RemoveLast();
            list.Display();
            */

            // UC7 - search the value og node in linked list

            /*
            list.InsertEnd(56);
            list.InsertEnd(30);
            list.InsertEnd(70);

            list.Display();

            list.searchNode(30);
            */

            // UC8 - insert an given element after a specific element

            list.InsertEnd(56);
            list.InsertEnd(30);
            list.InsertEnd(70);

            list.Display();

            list.InsertAfter(30, 40);

            list.Display();

            // UC9 - Delete a given data and count the size of list

            list.Remove(40);

            list.Display();

            list.countNodes();

        }
    }
}
