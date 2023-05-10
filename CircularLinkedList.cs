using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class CircularLinkedList<T>
    {

        private NodeT<T> head;
        private NodeT<T> tail;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public NodeT<T> Head { get { return head; } }
        public NodeT<T> Tail { get { return tail; } }

        public CircularLinkedList()
        {
            head = null;
            count = 0;
        }

        public CircularLinkedList(T[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }


            foreach (T item in data)
            {
                AddLast(item);
            }
        }

        public void AddLast(T el)
        {
            NodeT<T>newNode = new NodeT<T>(el);
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
            count++;

        }

        public T[] ToArray()
        {
            T[] array = new T[count];
            NodeT<T> current = head;

            for (int i = 0; i < count; i++)
            {
                array[i] = current.Data;
                current = current.Next;
            }

            return array;
        }

        public T First()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Список пуст");
            }

            return head.Data;
        }

        public bool Contains(T el)
        {
            NodeT<T> current = head;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(el))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void AddAfter(T searchValue, T newValue)
        {
            NodeT<T> current = head;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(searchValue))
                {
                    NodeT<T> newNode = new NodeT<T>(newValue);
                    newNode.Next = current.Next;
                    current.Next = newNode;

                    if (current == head && count == 1)
                    {
                        head = newNode;
                    }

                    count++;
                    break;
                }

                current = current.Next;
            }
        }

        public void AddBefore(T searchValue, T newValue)
        {
            NodeT<T> current = head;

            for (int i = 0; i < count; i++)
            {
                if (current.Next.Data.Equals(searchValue))
                {
                    NodeT<T> newNode = new NodeT<T>(newValue);
                    newNode.Next = current;
                    current.Next = newNode;

                    if (current == head && count == 1)
                    {
                        head = newNode;
                    }

                    count++;
                    break;
                }

                current = current.Next;
            }
        }

        public void AddListAfter(T item, CircularLinkedList<T> list)
        {
            NodeT<T> current = head;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(item))
                {
                    NodeT<T> lastNode = list.head;

                    while (lastNode.Next != null)
                    {
                        lastNode = lastNode.Next;
                    }

                    lastNode.Next = current.Next;
                    current.Next = list.head;

                    if (current == head && count == 1)
                    {
                        head = list.head;
                    }

                    count += list.count;
                    break;
                }

                current = current.Next;
            }
        }

        public override string ToString()
        {
            if (count == 0)
            {
                return "[]";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            NodeT<T> currentNode = head;
            for (int i = 0; i < count; i++)
            {
                sb.Append(currentNode.Data);
                if (i < count - 1)
                {
                    sb.Append(", ");
                }
                currentNode = currentNode.Next;
            }
            sb.Append("]");

            return sb.ToString();
        }

        public void DecrementCount()
        {
            count--;
        }

    }
}
