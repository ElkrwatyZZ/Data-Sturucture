using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Sturucture
{
    class recursionRevers
    {
        public int sizee;
        public int[] arraysatck;
        public int top;
        public recursionRevers(int sizee)
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
           // Console.WriteLine(arraysatck[top]);
          foreach(int x in arraysatck)
            {
                Console.WriteLine(arraysatck[x]);
            }
        }

    }
}
