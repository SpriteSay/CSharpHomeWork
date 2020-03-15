using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = null;
            tail = null;
        }
        
        public Node<T> Head
        {
            get { return head; }
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }else
            {
                tail.Next = n;
                tail = n;
            }

        }

        public void ForEach(Action<T> action)
        {
            for(Node<T> m = head; m.Next != null; m = m.Next)
            {
                action(m.Data);
            }
        }
    }
}
