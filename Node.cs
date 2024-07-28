using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class Node
    {
        //similar to ass 3
        object element;
        Node next;//NEXT 

        public Node(object o)
        {
            Element = o;
        }
        public Node(object o, Node n) { }

        public object Element { get => element; set => element = value; }
        public Node Next { get => next; set => next = value; }
    }
}
