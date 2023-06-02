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
            
            // UC 2 - Insert Nodes
            list.Insert(56);
            list.Insert(30);
            list.Insert(70);

            list.Display();
            
        }
    }
}
