using System;

namespace Data_Sturucture
{
    class linkedlistQueue<T>
    {
        NodeDouble<T> Rear;
        NodeDouble<T> Front;

        public linkedlistQueue(NodeDouble<T> NewNode)
        {
            Rear = NewNode;
            Front = NewNode;
        }

        Boolean isempaty()
        {
            return (Front.next == null);
        }

        public void Queue(NodeDouble<T> newNode)
        {
            newNode.next = null;
            newNode.prevous = Rear;
            Rear.next = newNode;
            Rear = newNode;
        }

        public T DeQueue()
        {
            if (isempaty())
            {
                Console.WriteLine("the LinkedList Queue is empaty");
                return default(T);
            };
            T value = Front.value;
            Front = Front.next;
            Front.prevous = null;
            return value;

        }
    }
}