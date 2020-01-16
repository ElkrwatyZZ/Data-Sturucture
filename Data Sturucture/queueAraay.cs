using System;

namespace Data_Sturucture
{
    public class queueAraay<T>
    {
        public object[] Array;
        public int Rear;

        public int Front;

        int Size;

        public queueAraay(int Size)
        {
            this.Size = Size;
            Array = new object[this.Size];
            Front = -1;
            Rear = -1;
        }

        Boolean isfull()
        {
            return (Rear == Size - 1);

        }

        Boolean isempaty()
        {
            return (Front == -1 || Front > Rear);

        }

        public void Queue(Object newitem)
        {
            if (isfull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            Rear = Rear + 1;
            Array[Rear] = newitem;
            if (Front == -1)
            {
                Front = 0;
            }
        }

        public T DeQueue()
        {

            if (isempaty())
            {
                Console.WriteLine("Queue is empaty");
                return default(T);
            }
            T ObjectOut = (T)Array[Front];
            Front = Front + 1;
            return ObjectOut;
        }
    }
}
