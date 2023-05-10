using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class DoublyLinkedList
    {

        private Node head;
        private Node tail;
        private int size;


        public int Size
        {
            get { return size; }
        }

        public int GetFirst
        {
            get
            {
                if (head == null)
                {
                    throw new Exception();
                }
                return head.Value;
            }
        }


        public Node FirstNode
        {
            get
            {
                return head;
            }
        }

        public Node LastNode
        {
            get
            {
                return tail;
            }
        }

        public int GetLast
        {
            get
            {
                if (tail == null)
                {
                    throw new Exception();
                }
                return tail.Value;
            }
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            size++;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Prev = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            size++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node node = head;
            while (node != null)
            {
                sb.Append(node.Value);
                if (node.Next != null)
                {
                    sb.Append(" ");
                }
                node = node.Next;
            }
            return sb.ToString();
        }

        public Node GetNodeAt(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }

            Node node = head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            return node;
        }
    }

}
