using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {
            data = 0;
            next = null;
        }

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public override string ToString()
        {
            return data.ToString() + " ";
        }
    }
}
