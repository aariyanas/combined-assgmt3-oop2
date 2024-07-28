using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class Node
    {
        object element;
        Node next;

        public object Element { get; set; }
        public Node Next { get; set; }

        public Node(object element)
        {
            Element = element;
            /*            this.next = null;*/
        }
    }
}
