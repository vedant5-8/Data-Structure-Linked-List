using System;
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

            list.InsertEnd(56);
            list.InsertEnd(30);
            list.InsertEnd(70);

            list.Display();


        }
    }
}
