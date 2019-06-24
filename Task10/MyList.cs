using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class MyList
    {
        private Node head;
        //создание списка
        public Node Create(int n)
        {
            head = new Node(1);
            Node temp = head;
            int i = 2;
            while (i <= n)
            {
                temp = temp.next = new Node(i++);
            }
            temp.next = head;
            return head;
        }
        //удаление элемента
        public int Delete(int m)
        {
            if (head != head.next)
            {
                int m1 = m - 1;
                int i = 1;
                while (i < m1)
                {
                    i++;
                    head = head.next;
                }
                head = head.next = head.next.next;
                this.Delete(m);
            }
            return head.data;
        }
    }  
}
