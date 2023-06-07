using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Linked_List
{
    internal class Node<T> where T : IComparable<T>
    {
        // UC1 - Create a linked list
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
            Next = null;
        }
    }
}
