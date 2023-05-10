using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class NodeT<T>
    {
        public T Value;
        public NodeT<T> Prev;

        public NodeT(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public NodeT<T> Next { get; set; }

    }
}
