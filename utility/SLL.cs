using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        Node head;
        Node tail;
        public int size = 0;
        public void Append(object data)
        {
            if (IsEmpty())
            {
                head = tail = new Node(data);//list is empty new node is only node
            }
            else
            {
                tail.Next = new Node(data);
                tail = tail.Next;
            }
            size++;
        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public bool Contains(object data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Delete(int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Index is out of the valid range.");
            }
            Node pre = head;//start
            if (index == 0)
            {
                head = pre.Next;
            }
            for (int j = 0; j < index - 1; j++)
                pre = pre.Next;
            Node del = pre.Next, after = del.Next;
            pre.Next = after;
            if (del == tail)
            {
                tail = pre;
            }
            size--;
        }

        public int IndexOf(object data)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (current.Element.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1; // Return -1 if data is not found
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Index is out of the valid range.");
            }

            Node toInsert = new Node(data);

            if (index == 0)
            {
                // Inserting at the beginning
                toInsert.Next = head;
                head = toInsert;
                if (size == 0)
                {
                    tail = toInsert;
                }
            }
            else if (index == size)
            {
                // Inserting at the end
                tail.Next = toInsert;
                tail = toInsert;
            }
            else
            {
                // Inserting in the middle
                Node pre = head;
                for (int j = 0; j < index - 1; j++)
                {
                    pre = pre.Next;
                }
                toInsert.Next = pre.Next;
                pre.Next = toInsert;
            }

            size++;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Prepend(object data)
        {
            Node toAdd = new Node(data);
            if (tail == null)//if list empty
            {
                head = toAdd;
                tail = head;
            }
            else
            {
                toAdd.Next = head;
                head = toAdd;
            }
            size++;
        }

        public void Replace(object data, int index)
        {
            if (index < 0 || index >= size -1)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            current.Element = data;
        }



        public object Retrieve(int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Index is out of the valid range.");
            }
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Element;
        }

        public int Size()
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                return size;
            }
        }
    }
}
