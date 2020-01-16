using System;

namespace Data_Sturucture
{
    public class linkedlist
    {
        node head;
        public linkedlist(node head)
        {
            this.head = head;
        }
        public void add(node newNode)
        { //time-complextiy=o(1)
            newNode.next = head;
            head = newNode;
        }
        public void delate()
        {    //time-complextiy=o(1)
            head = head.next;
        }
        public void display()
        {
            node n = head;
            while (n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }
        }
    }
}
