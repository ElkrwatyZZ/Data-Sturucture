using System;

namespace Data_Sturucture
{
    public class StacklinkedList
    {
        node head;
        public StacklinkedList(node head)
        {
            this.head = head;
        }

        public void push(node newitem)
        {
            head = newitem;
            newitem.next = head;
        }
        public void pop()
        {
            head = head.next;
        }

        public void display()
        {
            node n = head;
            if (n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }
        }
    }
}
