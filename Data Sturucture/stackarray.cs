using System;

namespace Data_Sturucture
{
    public class stackarray
    {
        public int sizee;
        public int[] arraysatck;
        public int top;
        public stackarray(int sizee)
        {
            this.sizee = sizee;
            arraysatck = new int[this.sizee];
            top = -1;
        }

        public int push(int newitem)
        {
            if (top == sizee - 1)
            {  ///stazk is full 
                Console.WriteLine("stazk is full");
                return 0;
            }
            else
            {
                top = top + 1;
                return arraysatck[top] = newitem;
            }
        }
        public void display()
        {
            Console.WriteLine(arraysatck[top]);
        }

        public int pop()
        {
            if (top == -1)
            { /// stack is empaty
                Console.WriteLine("stack is empaty");
                return 0;
            }
            else
            {
                int item = arraysatck[top];
                top = top - 1;
                return item;
            }
        }
    }
}
